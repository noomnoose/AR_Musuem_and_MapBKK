using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour
{
    public GameObject ui;

public void OnClick()
    {
        ui.SetActive(true);
        Debug.Log("Clicked");
    }

}
