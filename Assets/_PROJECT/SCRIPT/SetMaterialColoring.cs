using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterialColoring : MonoBehaviour
{

    public Material[] material;
    Renderer rend;
    // Start is called before the first frame update



  
    //public float timeRemainnig = 0.5f;
//    public bool timeIsRunning = false;


    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }


    void Update()
    {
        /*
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
            }
        }
        */
    }

    public void Coloring()
    {
        rend.sharedMaterial = material[1];
        ///timeIsRunning = true;
       // timeRemainnig = 0.5f;
       // Debug.Log("chang material");
    }

 

    public void Original()
    {
        rend.sharedMaterial = material[0];
    }
}
