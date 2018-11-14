using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuitter : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        // Have a quit button to exit the application
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Debug.Log("Quit Game");
            Application.Quit();
        }
	}
}
