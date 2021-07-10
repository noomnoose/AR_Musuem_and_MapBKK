using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterial : MonoBehaviour
{

    public Material[] material;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }


    public void Coloring()
    {
        
        rend.sharedMaterial = material[1];
    }

    public void Original()
    {
        rend.sharedMaterial = material[0];
    }
}
