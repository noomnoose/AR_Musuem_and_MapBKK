using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterial : MonoBehaviour
{

    public Material[] material;
    Renderer rend;
    // Start is called before the first frame update



    public float timeReset;
    public float timeRemainnig;
    public bool timeIsRunning = false;


    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
       // rend.sharedMaterial = material[0];
    }


    void Update()
    {
        if (timeIsRunning)
        {

            if (timeRemainnig > 0)
            {
                timeRemainnig -= Time.deltaTime;
            }
            else
            {
                timeIsRunning = false;
                rend.sharedMaterial = material[0];
                Debug.Log("เรียกสีน้ำตาล");
            }
        }
    }

    public void Coloring()
    {
        rend.sharedMaterial = material[1];
        timeIsRunning = true;
        timeRemainnig = timeReset;
        Debug.Log("chang material");
    }

 

    public void Original()
    {
       /// rend.sharedMaterial = material[1];
        StartCoroutine(delaMat());
    }


    IEnumerator delaMat()
    {
        yield return new WaitForSeconds(0.1f);
        rend.sharedMaterial = material[0];
        Debug.Log("เปลี่ยน");

    }
}
