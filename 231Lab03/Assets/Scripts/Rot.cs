using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rot : MonoBehaviour
{
    public Slider slide;
    public void ValueChange()
    {
        transform.localEulerAngles = new Vector3(slide.value, 0, 0);
    }
}
