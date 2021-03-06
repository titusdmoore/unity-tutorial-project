﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;

    public float forwardForce;
    public float horizontalForce;

    private bool isRight;

    // Start is called before the first frame update
    void Start() {
    }

/*    void OnGUI() {
        Event e = Event.current;

        //Check the type of the current event, making sure to take in only the KeyDown of the keystroke.
        //char.IsLetter to filter out all other KeyCodes besides alphabetical.
        if (e.type == EventType.KeyDown && e.keyCode.ToString().Length == 1 && char.IsLetter(e.keyCode.ToString()[0]) && (e.keyCode == KeyCode.A || e.keyCode == KeyCode.D)) {
            isMoving = true;
            

            if (e.keyCode == KeyCode.D) {
                isRight = true;
            } else {
                isRight = false;
            }
        } else if (e.type == EventType.KeyUp) {
            isMoving = false;
        }
    }
*/

    // Update is called once per frame
    // FixedUpdate is best practice for physics
    void FixedUpdate() {
        if (Input.GetKey("a") || Input.GetKey("d")) {
            if (Input.GetKey("d")) {
                isRight = true;
            } else {
                isRight = false;
            }


            rb.AddForce(isRight
                ? horizontalForce * Time.deltaTime
                : -horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (rb.position.y < -1.5) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
