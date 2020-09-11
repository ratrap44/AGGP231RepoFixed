
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject VB;
    public GameObject Sphere;
    public Color1 Colormanager;
    
    void start()
    {
        VB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //material = GetComponent<Renderer>().material;

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("VB pressed");
        Colormanager.start();
        Colormanager.setcolor();
        

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("VB released");
        Colormanager.back();
        //material.color = Color.black;
        
    }
}
