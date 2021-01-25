﻿using Microsoft.MixedReality.WebRTC;
using Microsoft.MixedReality.WebRTC.Unity;
using SocketIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class SocketIOSignaler : Signaler
{
    private const string STREAM_NAME_PREFIX = "unity_stream";

    public SocketIOComponent socket;

    public string localPeerId;

    public string remotePeerId;

    //public MicrophoneSource microphoneSource;

    //public WebcamSource webcamSource;

    public string signalingServerIp;

    private Task SendIOMessage(string type, JSONObject payload)
    {
        JSONObject message = new JSONObject();
        message.AddField("to", remotePeerId);
        message.AddField("type", type);
        message.AddField("payload", payload);
        socket.Emit("message", message);
        //Debug.Log($"SendIOMessage remotePeer = {remotePeerId}; type = {type}");
        
        return Task.CompletedTask;
    }

    public override Task SendMessageAsync(SdpMessage message)
    {
        JSONObject payload = new JSONObject();
        string type = message.Type.ToString().ToLower();
        payload.AddField("type", type);
        payload.AddField("sdp", message.Content.Replace("\r\n", "\\r\\n"));
        return SendIOMessage(type, payload);
    }

    public override Task SendMessageAsync(IceCandidate candidate)
    {
        JSONObject payload = new JSONObject();
        payload.AddField("label", candidate.SdpMlineIndex);
        payload.AddField("id", candidate.SdpMid);
        payload.AddField("candidate", candidate.Content);
        return SendIOMessage("candidate", payload);
    }

    public void Connect()
    {
        _nativePeer.DataChannelAdded += OnDataChannelAdded;
        var prevSocket = socket;
        socket.url = $"ws://{signalingServerIp}:9092/socket.io/?EIO=4&transport=websocket";
        socket = Instantiate(socket);
        Destroy(prevSocket.gameObject);
        socket.On("id", OnId);
        socket.On("remoteId", OnRemoteId);
        socket.On("message", OnMessage);
        socket.On("connect", (ev) => { Debug.Log("socket state connect"); });
        socket.On("disconnect", (ev) => { Debug.Log("socket state disconnect"); });
        socket.On("connect", (ev) => { Debug.Log("socket state connect"); });
        socket.On("error", (ev) => {
            //Debug.Log("socket state error ");
        });
        socket.Connect();
        Debug.Log($"socket start connect to {socket.url}");
    }


    private void OnDataChannelAdded(DataChannel channel)
    {
        channel.MessageReceived += OnDataChannelMessageReceived;
    }

    private void OnDataChannelMessageReceived(byte[] data)
    {
        string dataStr = Encoding.UTF8.GetString(data);
        Debug.Log("Received data channel message: " + dataStr);
        JSONObject obj = JSONObject.Create(dataStr);
        switch (GetString(obj, "type"))
        {
            case "CONDITION":
                var condition = (StudyManager.Conditions)GetInt(obj, "value");
                Debug.Log("Experiment condition: " + condition);
                StudyManager.Instance.SetContiditon(condition);
                break;
            case "DEVICE_PARAMS":
                float width = GetFloat(obj, "width");
                float height = GetFloat(obj, "height");
                float ratio = GetFloat(obj, "ratio");
                StudyManager.Instance.SetScreenAndPhoneSize(width, height, ratio);
                break;
        }
    }


    private void OnId(SocketIOEvent ev)
    {
        string id = GetString(ev.data, "id");
        Debug.Log($"OnId {id}");
        OnStatusChanged("READY");
        OnReady(id);
    }

    private void OnRemoteId(SocketIOEvent ev)
    {
        remotePeerId = GetString(ev.data, "id");
        Debug.Log($"OnRemoteId {remotePeerId}");
        SendIOMessage("init", null);
    }

    public static string GetString(JSONObject jObject, string name)
    {
        string field = null;
        jObject.GetField(ref field, name);
        return field;
    }

    private static int GetInt(JSONObject jObject, string name)
    {
        int field = 0;
        jObject.GetField(ref field, name);
        return field;
    }

    private static float GetFloat(JSONObject jObject, string name)
    {
        float field = 0;
        jObject.GetField(ref field, name);
        return field;
    }

    private void OnMessage(SocketIOEvent ev)
    {
        string from = GetString(ev.data, "from");
        remotePeerId = from;
        string type = GetString(ev.data, "type");
        //Debug.Log($"socket received {type} from {from}");
        JSONObject payload = null;
        if (type != "init")
        {
            payload = ev.data["payload"];
        }

        Debug.Log(ev.data);
        switch (type)
        {
            case "init":
                _ = PeerConnection.StartConnection();
                break;
            case "offer":
                var sdpOffer = new SdpMessage { Type = SdpMessageType.Offer, Content = GetString(payload, "sdp").Replace("\\r\\n", "\r\n") };
                PeerConnection.HandleConnectionMessageAsync(sdpOffer).ContinueWith(_ =>
                {
                    _nativePeer.CreateAnswer();
                }, TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.RunContinuationsAsynchronously);
                break;
            case "answer":
                var sdpAnswer = new SdpMessage { Type = SdpMessageType.Answer, Content = GetString(payload, "sdp").Replace("\\r\\n", "\r\n") };
                _ = PeerConnection.HandleConnectionMessageAsync(sdpAnswer);
                break;
            case "candidate":
                _nativePeer.AddIceCandidate(new IceCandidate()
                {
                    SdpMid = GetString(payload, "id"),
                    SdpMlineIndex = GetInt(payload, "label"),
                    Content = GetString(payload, "candidate")

                });
                break;
        }
    }

    private void StartStream(string name)
    {
        JSONObject message = new JSONObject();
        message.AddField("name", name);
        socket.Emit("readyToStream", message);
        OnStatusChanged("STREAMING");
    }

    private void OnReady(string peerId)
    {
        localPeerId = peerId;
        StartStream(STREAM_NAME_PREFIX);
    }

    private void OnStatusChanged(string newStatus)
    {
        Debug.Log($"onStatusChanged {newStatus}");
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.P))
        {
            SendIOMessage("init", null);
        }
    }
}
