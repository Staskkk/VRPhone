﻿using SolAR;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DeviceCameraScript : MonoBehaviour
{
    public RawImage image;
    public RectTransform imageParent;
    public AspectRatioFitter imageFitter;

    public SolARPipeline solarScript;

    public GameObject[] objectsToDeactivate;

    public WebCamTexture activeCameraTexture;

    private WebCamDevice activeCameraDevice;

    // Image rotation
    Vector3 rotationVector = new Vector3(0f, 0f, 0f);

    // Image uvRect
    Rect defaultRect = new Rect(0f, 0f, 1f, 1f);
    Rect fixedRect = new Rect(0f, 1f, 1f, -1f);

    // Image Parent's scale
    Vector3 defaultScale = new Vector3(1f, 1f, 1f);
    Vector3 fixedScale = new Vector3(-1f, 1f, 1f);

    void OnEnable()
    {
        foreach (var obj in objectsToDeactivate)
        {
            obj.SetActive(false);
        }
    }

    void OnDisable()
    {
        foreach (var obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }
    }

    void Start()
    {
        //if (Screen.width > Screen.height)
        //{
        //    imageFitter.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        //}
        //else
        //{
        //    imageFitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        //}

        //image.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);

        // Check for device cameras
        if (WebCamTexture.devices.Length == 0)
        {
            Debug.Log("No devices cameras found");
            this.enabled = false;
            return;
        }

        activeCameraDevice = WebCamTexture.devices.First();
        activeCameraTexture = new WebCamTexture(activeCameraDevice.name, solarScript.width, solarScript.height);
        activeCameraTexture.filterMode = FilterMode.Trilinear;

        UpdateScreenParams();
        image.texture = activeCameraTexture;
        image.material.mainTexture = activeCameraTexture;
        
        activeCameraTexture.Play();
        solarScript.gameObject.SetActive(true);
    }

    public void UpdateScreenParams()
    {
        var rectTransform = GetComponent<RectTransform>();
        var rectWidth = rectTransform.rect.width;
        var rectHeight = rectTransform.rect.height;

        //if (rectWidth > rectHeight)
        //{
        //    image.rectTransform.sizeDelta = new Vector2(rectWidth, rectWidth * solarScript.height / solarScript.width);
        //}
        //else
        //{
        //    image.rectTransform.sizeDelta = new Vector2(rectHeight * solarScript.width / solarScript.height, rectHeight);
        //}

        image.rectTransform.sizeDelta = new Vector2(1920 * 2, 1080 * 2);
        //image.texture = activeCameraTexture;
        //image.material.mainTexture = activeCameraTexture;
    }

    // Make adjustments to image every frame to be safe, since Unity isn't 
    // guaranteed to report correct data as soon as device camera is started
    void Update()
    {
        // Skip making adjustment for incorrect camera data
        if (activeCameraTexture.width < 100)
        {
            Debug.Log("Still waiting another frame for correct info...");
            return;
        }

        UpdateScreenParams();

        // Rotate image to show correct orientation 
        rotationVector.z = -activeCameraTexture.videoRotationAngle;
        image.rectTransform.localEulerAngles = rotationVector;

        // Set AspectRatioFitter's ratio
        //float videoRatio =
        //    (float)activeCameraTexture.width / (float)activeCameraTexture.height;
        //Debug.Log(videoRatio);
        //imageFitter.aspectRatio = videoRatio;

        // Unflip if vertically flipped
        image.uvRect =
            activeCameraTexture.videoVerticallyMirrored ? fixedRect : defaultRect;

        // Mirror front-facing camera's image horizontally to look more natural
        imageParent.localScale =
            activeCameraDevice.isFrontFacing ? fixedScale : defaultScale;
    }
}