using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float rotSpeed;
    public FloatingJoystick joystick;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    void Update()
    {
        this.transform.eulerAngles = new Vector3((joystick.Vertical * 90) / Mathf.PI, 0, -(joystick.Horizontal * 90) / Mathf.PI);
    }
}
