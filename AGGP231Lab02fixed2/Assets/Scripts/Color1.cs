using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color1 : MonoBehaviour
{
    Material mat;
    //GameObject gamobj;
    public void start()
    {
        
        mat = GetComponent<Renderer>().material;
    }
    public void setcolor()
    {
        if (this.gameObject.tag == "Sphere")
        {
            mat.color = Color.red;
        }
        if (this.gameObject.tag == "Cube")
        {
            mat.color = Color.blue;
        }
        if (this.gameObject.tag == "Capsul")
        {
            mat.color = Color.green;
        }
        if (this.gameObject.tag == "Cylander")
        {
            mat.color = Color.yellow;
        }
        if (this.gameObject.tag == "Sphere2")
        {
            mat.color = Color.magenta;
        }
        if (this.gameObject.tag == "Cube2")
        {
            mat.color = Color.white;
        }
    }

    public void back()
    {
       mat.color = Color.black;      
    }
    
}
