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

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Hole_blue":
                if (colour.name.ToLower() == "blue")
                    Debug.Log("blue");
                break;
            case "Hole_green":
                if (colour.name.ToLower() == "green")
                    Debug.Log("green");
                break;
            case "Hole_yellow":
                if (colour.name.ToLower() == "yellow")
                    Debug.Log("yellow");
                break;
            case "Hole_red":
                if (colour.name.ToLower() == "red")
                    Debug.Log("red");
                break;
        }
    }
}
