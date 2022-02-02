using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OVRInputTest : MonoBehaviour
{
    private OVRInput.Controller controller;
    private float amplitubecontrol;

    // Start is called before the first frame update
    void Start()
    {
        // OVRControllerHelperÇ©ÇÁç∂âEÇ«Ç¡ÇøÇ©ÇéÊìæÇ∑ÇÈ
        controller = GetComponent<OVRControllerHelper>().m_controller;
    }

    // Update is called once per frame
    void Update()
    {
        

        //Debug.Log((float)Math.Pow(Math.Abs(transform.rotation.eulerAngles.z), 2.0f) / 8100.0f-4);

        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.Touch))
        {
            float value = (float)Math.Pow(Math.Abs(transform.rotation.eulerAngles.z), 2.0f) / 8100.0f -4.0f;
            OVRInput.SetControllerVibration(0.1f, Mathf.Clamp(value, 0.0f, 1.0f), OVRInput.Controller.LTouch);
        }
        else
        {
            OVRInput.SetControllerVibration(0, 0);
        }
    }
}
