using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color6 : MonoBehaviour
{
    Material mat;
    public void start()
    {
        mat = GetComponent<Renderer>().material;
    }
    public void setcolor()
    {
        mat.color = Color.white;
    }

    public void back()
    {
        mat.color = Color.black;
    }
}
