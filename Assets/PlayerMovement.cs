﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float horizontalForce = 0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update() {
        //userInput = Input.inputString;
    }

    // Update is called once per frame
    // FixedUpdate is best practice for physics
    void FixedUpdate()
    {

        if (Input.GetKey("d")) {
            horizontalForce = 500f;
        } else if (Input.GetKey("a")) {
            horizontalForce = -500f;
        } else {
            horizontalForce = 0f;
        }
        
        rb.AddForce(horizontalForce * Time.deltaTime, 0, forwardForce * Time.deltaTime);

    }
}
