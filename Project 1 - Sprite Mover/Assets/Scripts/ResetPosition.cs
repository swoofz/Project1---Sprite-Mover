using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this code is for gameobject who parent == null
public class ResetPosition : MonoBehaviour {

    // Delcare Variable
    private Transform tf; // Create a Variable for the transform component

	// Use this for initialization
	void Start () {
        // Load transform component into our variable
        tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        // if space is press set position to the center of the world (0,0,0)
        if (Input.GetKeyDown(KeyCode.Space)) {
            tf.position = new Vector3(0, 0, 0);
        }
	}
}
