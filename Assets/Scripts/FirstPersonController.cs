using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FirstPersonController : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mainCam;
    public Joystick joystick;
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward.normalized * joystick.Vertical * 5f * Time.deltaTime,Space.World);
        //rb.MovePosition(transform.position + transform.forward.normalized * joystick.Vertical * 5f * Time.deltaTime);
        transform.Rotate(Time.deltaTime * new Vector3(0,30,0) * Convert.ToSingle(Math.Round(joystick.Horizontal,1)));
    }
}
