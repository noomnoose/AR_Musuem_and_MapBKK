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
    public float rotatespeed = 10f;
    private float _startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        startQuaternion = transform.rotation;
        //quaternionToVcetor = startQuaternion.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    _startingPosition = touch.position.x;
                    break;
                case TouchPhase.Moved:
                    if (_startingPosition > touch.position.x)
                    {

                       // transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(reverseQuaternion), Time.deltaTime * lerpTime);
                       // transform.Rotate(Vector3.back, -rotatespeed * Time.deltaTime);
                    }
                    else if (_startingPosition < touch.position.x)
                    {

                       // transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(reverseQuaternion), Time.deltaTime * lerpTime);
                       // transform.Rotate(Vector3.back, rotatespeed * Time.deltaTime);
                    }
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Touch Phase Ended.");
                    break;
            
            }
        }
    



        if (rotate)
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(reverseQuaternion), Time.deltaTime * lerpTime);
        if (rotateConstantly && !rotate)
            transform.Rotate(Vector3.up * RotateAmount);
    }
}
