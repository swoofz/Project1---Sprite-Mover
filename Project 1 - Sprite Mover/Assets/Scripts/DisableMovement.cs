using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMovement : MonoBehaviour {

    //Delcare Variables
    public GameObject go; // Create a Variable for a gameObject
    private bool movementOn; // Create a Variable to track component's enabled 

	// Use this for initialization
	void Start () {
        // Check if loaded a gameObject 
        if (go != null) {
            movementOn = go.GetComponent<SpriteMover>().enabled; // set up our movement varibale equal to gameObject component enabled
        }
    }

    // Update is called once per frame
    void Update () {
        // Check for key P to be pressed
        if (Input.GetKeyDown(KeyCode.P)) {
            // check if component enabled
            if(movementOn) {
                go.GetComponent<SpriteMover>().enabled = false; // disable component
            } else {
                go.GetComponent<SpriteMover>().enabled = true; // enable component
            }
            // Setting movementOn to switch everytime P is pressed to stay the same as SpriteMover component enabled value
            movementOn = !movementOn; // Same and probably better to understand as (movementOn = go.GetComponent<SpriteMover>().enabled;)
        }

    }
}
