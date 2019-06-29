using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.VR;

public class cameraToRV : MonoBehaviour
{

    //private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchToVR());
        //Camera.main.ResetAspect();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private IEnumerator SwitchToVR()
    {
        string desiredDevice = "cardboard";
        //Camera.main.transform.localRotation = Quaternion.identity;
        if (string.Compare(XRSettings.loadedDeviceName, desiredDevice, true) != 0)
        {
            XRSettings.LoadDeviceByName(desiredDevice);
            yield return null;
        }
        XRSettings.enabled = true;
    }



}
