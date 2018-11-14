using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InActive : MonoBehaviour {

    // Declare Variable
    public GameObject go;

	// Use this for initialization
	void Start () {
        if (go == null) {
            Debug.Log("Attach GameObject");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q)) {
            go.SetActive(!go.activeSelf);
        }
	}
}
