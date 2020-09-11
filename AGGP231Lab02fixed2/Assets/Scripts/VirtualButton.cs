using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject VB;
    public GameObject Sphere;
    public Material material;
    
    void start()
    {
        VB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //material = GetComponent<Renderer>().material;

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Sphere.SetActive(false);
        //material.color = Color.red;
        Debug.Log("VB pressed");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Sphere.SetActive(true);
        //material.color = Color.black;
        Debug.Log("VB released");
    }
}
