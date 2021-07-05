using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetsGameObjects : MonoBehaviour
{
    public GameObject objects,scanPoint;
    public GameObject jar;
    public GameObject dish;
    public GameObject legs;
    public GameObject buff;
    public GameObject leo;
    public float timeRemainnig = 3;
    public bool timeIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
       // jar.gameObject.SetActive(false);
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
                jar.gameObject.SetActive(true);
                dish.gameObject.SetActive(true);
                legs.gameObject.SetActive(true);
                buff.gameObject.SetActive(true);
                leo.gameObject.SetActive(true);

               scanPoint.gameObject.SetActive(false);
                
            }
        }

    }

    public void TimeRunnig()
    {
        timeIsRunning = true;
        jar.gameObject.SetActive(false);
        dish.gameObject.SetActive(false);
        legs.gameObject.SetActive(false);
        buff.gameObject.SetActive(false);
        leo.gameObject.SetActive(false);

        //objects.gameObject.SetActive(false);
        scanPoint.gameObject.SetActive(true);
        timeRemainnig = 3;
        Debug.Log("false");
    }
}
