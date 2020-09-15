using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scal : MonoBehaviour
{
    public Slider slide;
    // Update is called once per frame
    public void ValueChange()
    {
        transform.localScale = new Vector3(slide.value, slide.value, slide.value);
    }
}
