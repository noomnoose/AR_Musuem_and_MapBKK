using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchRotate : MonoBehaviour
{
    public Quaternion startQuaternion;
    public Vector3 quaternionToVcetor;
    public Vector3 reverseQuaternion;
    public float lerpTime = 1;
    public float RotateAmount = 1;

    public bool rotate;
    public bool rotateConstantly;


    private Touch touch;
    // Start is called before the first frame update
    void Start()
    {
        startQuaternion = transform.rotation;
        //quaternionToVcetor = startQuaternion.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {   /*
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                reverseQuaternion.x = +10;

            }
        }*/
             // .1 -> .2 x+
              // reverseQuaternion.x = +10; <= 45  +0
      if (Input.GetKeyDown(KeyCode.D))
        {
            if (reverseQuaternion.x <= 45)
            {
                reverseQuaternion.x = +1;
            }
            else if (reverseQuaternion.x >= -45)
            {
                reverseQuaternion.x =+ 1;
            }
        }

        if (rotate)
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(reverseQuaternion), Time.deltaTime * lerpTime);
        if (rotateConstantly && !rotate)
            transform.Rotate(Vector3.up * RotateAmount);
    }
}
