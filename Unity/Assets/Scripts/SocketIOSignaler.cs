﻿using Microsoft.MixedReality.WebRTC;
using Microsoft.MixedReality.WebRTC.Unity;
using SocketIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class SocketIOSignaler : Signaler
{
    private const string STREAM_NAME_PREFIX = "unity_stream";

    public SocketIOComponent socket;

    public string remotePeerId;

    public MicrophoneSource microphoneSource;

    public WebcamSource webcamSource;

    private Task SendIOMessage(string type, JSONObject payload)
    {
        JSONObject message = new JSONObject();
        message.AddField("to", remotePeerId);
        message.AddField("type", type);
        message.AddField("payload", payload);
        socket.Emit("message", message);
        Debug.Log($"SendIOMessage remotePeer = {remotePeerId}; type = {type}");
        
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

    // Start is called before the first frame update
    void Start()
    {
        socket.On("id", OnId);
        socket.On("message", OnMessage);
        socket.On("connect", (ev) => { Debug.Log("socket state connect"); });
        socket.On("disconnect", (ev) => { Debug.Log("socket state disconnect"); });
        socket.On("connect", (ev) => { Debug.Log("socket state connect"); });
        socket.On("error", (ev) => {
            Debug.Log("socket state error ");
        });
        socket.Connect();
        Debug.Log("socket start connect");
    }

    private void OnId(SocketIOEvent ev)
    {
        string id = ev.data["id"].ToString();
        Debug.Log($"OnId {id}");
        OnStatusChanged("READY");
        OnReady(id);
    }

    public static string GetString(JSONObject jObject, string name)
    {
        string str = null;
        jObject.GetField(ref str, name);
        return str;
    }

    private static int GetInt(JSONObject jObject, string name)
    {
        int str = 0;
        jObject.GetField(ref str, name);
        return str;
    }

    private void OnMessage(SocketIOEvent ev)
    {
        string from = GetString(ev.data, "from");
        remotePeerId = from;
        string type = GetString(ev.data, "type");
        Debug.Log($"socket received {type} from {from}");
        JSONObject payload = null;
        if (type != "init")
        {
            payload = ev.data["payload"];
        }
        
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

    private void OnReady(string remoteId)
    {
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
        if (Input.GetKeyDown(KeyCode.F))
        {
            SendIOMessage("init", null);
        }
    }
}