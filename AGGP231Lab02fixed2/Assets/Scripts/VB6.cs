﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB6 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject VB;
    public GameObject Sphere;

    public Color6 Colormanager;

    void start()
    {
        VB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //material = GetComponent<Renderer>().material;

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Colormanager.start();
        Colormanager.setcolor();
        Debug.Log("VB pressed");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Colormanager.back();
        //material.color = Color.black;
        Debug.Log("VB released");
    }
}
