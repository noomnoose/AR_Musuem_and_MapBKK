using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollowCamera : MonoBehaviour
{
    void Update()
    {
        transform.forward = Camera.main.transform.forward;
      // transform.rotation = new Quaternion(0,0,0,0);
    }
}
