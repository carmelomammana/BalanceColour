using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float rotSpeed;

    private Rigidbody rb;
    private float xRot;
    private float zRot;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        xRot = Input.acceleration.x * rotSpeed;
        zRot = Input.acceleration.y * rotSpeed;

        transform.rotation = new Quaternion(xRot, 0, zRot, 0);
    }
}
