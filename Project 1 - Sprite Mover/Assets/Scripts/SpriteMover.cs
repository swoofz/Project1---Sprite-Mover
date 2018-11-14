using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour {
    
    // Declare Variables
    public float speed = 0.05f; // Create a Variable to adjust the movement speed
    private Transform tf; // Create a Varible for transform component
    private bool canMove; // Create a Variable to block movement inputs

	// Use this for initialization
	void Start () {
        // Load transform component into our variable
        tf = GetComponent<Transform>();
        canMove = true; // Make movement possible, set to true
	}
	
	// Update is called once per frame
	void Update () {
        // Move sprite if movement is possible
        if (canMove) {
            // Detemine the direction of movement: positive or negative
            tf.position += Vector3.right * Input.GetAxis("Horizontal") * speed; // Move right or left
            tf.position += Vector3.up * Input.GetAxis("Vertical") * speed; // Move up or down
        }

        // When the left shift key is pressed stop constant movement and move 1 unit in the direction speficied by input
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            canMove = false; // stops constant movements

            // Move 1 unit in the direction that the sprite was going.
            if (Input.GetAxis("Horizontal") > 0) {
                tf.position += Vector3.right; // 1 unit right
            }
            if (Input.GetAxis("Horizontal") < 0) {
                tf.position += Vector3.left; // 1 unit left
            }
            if (Input.GetAxis("Vertical") > 0) {
                tf.position += Vector3.up; // 1 unit up
            }
            if (Input.GetAxis("Vertical") < 0) {
                tf.position += Vector3.down; // 1 unit down
            }
        }

        // Turn constant movement on
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0 ){ // Making sure not pressing any arrow key
            canMove = true; // Movement turned on
        }
    }
}
