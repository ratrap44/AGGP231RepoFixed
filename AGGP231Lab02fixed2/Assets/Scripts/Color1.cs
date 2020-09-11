using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color1 : MonoBehaviour
{
    Material mat;
    public void start()
    {
        mat = GetComponent<Renderer>().material;
    }
    public void setcolor()
    {
        mat.color = Color.red;
    }

    public void back()
    {
        mat.color = Color.black;
    }
    
}
