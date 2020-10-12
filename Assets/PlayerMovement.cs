using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 0f;
    public float horizontalForce = 0f;
    public string userInput;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update() {
        userInput = Input.inputString;
    }

    // Update is called once per frame
    // FixedUpdate is best practice for physics
    void FixedUpdate()
    {

        /*if (Input.GetKey("d")) {
            horizontalForce = 500f;
        } else if (Input.GetKey("a")) {
            horizontalForce = -500f;
        } else {
            horizontalForce = 0f;
        }

        if (Input.GetKey("w")) {
            forwardForce = 500f;
        } else if (Input.GetKey("s")) {
            forwardForce = -500f;
        } else {
            horizontalForce = 0f;
        }*/

        string[] inputArray = userInput.Split();

        if (inputArray.Length > 0) {
            foreach (var key in inputArray) {
                switch (key) {
                    case "w":
                        forwardForce = 500f;
                        break;
                    case "a":
                        horizontalForce = -500f;
                        break;
                    case "s":
                        forwardForce = -500f;
                        break;
                    case "d":
                        horizontalForce = -500f;
                        break;
                    default:
                        break;
                }
            }

            rb.AddForce(horizontalForce * Time.deltaTime, 0, forwardForce * Time.deltaTime);
        }

        rb.AddForce(0, 0, 0);
    }
}
