using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingInfo : MonoBehaviour
{
    public Texture2D image;
    public string header;
    public string description;

    public BuildingInfoUI ui;

    void Start()
    {

    }

    public void OnClick()
    {
        if (ui.gameObject.activeSelf)
            return;

        Debug.Log("click: " + name);
        ui.Open(this);
    }

}
