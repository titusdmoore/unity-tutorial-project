using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;

    public float forwardForce;
    public float horizontalForce;

    private bool isMoving = false;
    private bool isRight;

    // Start is called before the first frame update
    void Start() {
    }

    void OnGUI() {

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
        }

    }


    // Update is called once per frame
    // FixedUpdate is best practice for physics
    void FixedUpdate() {
        rb.AddForce(isMoving 
            ? isRight 
                ? horizontalForce * Time.deltaTime
                : -horizontalForce * Time.deltaTime
            : 0, 0, forwardForce * Time.deltaTime);
    }
}
