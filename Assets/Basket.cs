using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour {

    public static int score = 0;
    public Text scoreText;

    // Use this for initialization
    void Start () {
        // Find reference to TextScore game object
        GameObject scoreObject = GameObject.Find("TextScore");
        scoreText = scoreObject.GetComponent<Text>();

        // Set starting number of points to zero
        score = 0;
        scoreText.text = "0 qəpik";
    }
	
	// Update is called once per frame
	void Update () {
        // Get the mouse position and position basket there
        Vector3 mousePos2D = Input.mousePosition;

        // The camera position defines the z coordinate
        mousePos2D.z = -Camera.main.transform.position.z;

        // Convert the point from 2D screen space into 3D scene
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        // Move the basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
	}

    // Check if the eggs hit the basket
    private void OnCollisionEnter(Collision collision) {
        // Catch eggs if they collide
        GameObject collideWith = collision.gameObject;
        if (collideWith.tag == "Egg") {
            Destroy(collideWith);

            // Update text on the screen 
            score += 10;
            scoreText.text = score.ToString() + " qəpik";
            
            // Update the high score if needed
            if (score > HighScore.score) {
                HighScore.score = score;
            }
        }
    }
}
