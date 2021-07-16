using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetsGameObjects : MonoBehaviour
{

    //reset position
    public Quaternion startRotation;


    //reset time object
    public GameObject jar;
    public float timeRemainnig;
    public bool timeIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (timeIsRunning)
        {
            
            if(timeRemainnig > 0)
            {
                timeRemainnig -= Time.deltaTime;
            }
            else
            {
                timeIsRunning = false;
               // objects.gameObject.SetActive(true);
                jar.gameObject.SetActive(false);
                
                
            }
        }

    }

    public void TimeRunnig()
    {
        timeIsRunning = true;
        jar.gameObject.SetActive(true);
        timeRemainnig = 1.5f;
        Debug.Log("false");
    }


    public void ResetRatation()
    {
        transform.rotation = startRotation;
    }
}
