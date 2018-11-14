using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMovement : MonoBehaviour {

    // Declare Variables
    private bool hasComponent; // Create a variable to proceed if component is there


    // Use this for initialization
    void Start() {
        // Checking GameObject of SpriteMover component
        if (gameObject.GetComponent<SpriteMover>() != null) {
            hasComponent = true;
        }
    }

    // Update is called once per frame
    void Update () {
        // Check for key P to be pressed and if the gameobject has component
        if (Input.GetKeyDown(KeyCode.P) && hasComponent) {
            // Disable/Enable gameobject's SpriteMover component
            gameObject.GetComponent<SpriteMover>().enabled = !gameObject.GetComponent<SpriteMover>().enabled;
        }
    }
}
