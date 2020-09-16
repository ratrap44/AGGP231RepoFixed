using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
   public GameObject ARsessionorigin;


    public void Turnon()
    {
        ARsessionorigin.GetComponent<MakeAppearOnPlane>().enabled = true;
    }

    public void Turnoff()
    {
        ARsessionorigin.GetComponent<MakeAppearOnPlane>().enabled = false;
    }
}
