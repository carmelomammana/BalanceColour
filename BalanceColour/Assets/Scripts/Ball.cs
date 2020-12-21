using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Material colour;

    void Start()
    {
        this.GetComponent<Renderer>().material = colour;
    }

    void Update()
    {
        
    }
}
