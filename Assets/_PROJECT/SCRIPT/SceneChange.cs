﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public enum _scene 
    {
        _MAIN,
        BKK_MAP,
        AR_Paint_Main
    }
    public _scene NextScene;
    public void onClickNextScene()
    {
        SceneManager.LoadScene(NextScene.ToString());
    }
}