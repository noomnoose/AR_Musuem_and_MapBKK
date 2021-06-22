using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_ch : MonoBehaviour
{
    public Material _material;


    public void SetColorRed()
    {
        _material.SetColor("_Color", Color.red);
    }

    public void SetColorGreen()
    {
        _material.SetColor("_Color", Color.green);
    }

    public void SetColorBlue()
    {
        _material.SetColor("_Color", Color.blue);
    }
}
