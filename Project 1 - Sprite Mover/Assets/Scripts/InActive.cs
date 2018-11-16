using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InActive : MonoBehaviour {

    // Declare Variable
    public GameObject go; // Create a varible to get a gameObject

	// Use this for initialization
	void Start () {
        if (go == null) {
            Debug.Log("Attach GameObject");
        }
	}
	
	// Update is called once per frame
	void Update () {
        // Set gameObject active or inactive
        if (Input.GetKeyDown(KeyCode.Q)) {
            go.SetActive(!go.activeSelf);
        }
	}
}
