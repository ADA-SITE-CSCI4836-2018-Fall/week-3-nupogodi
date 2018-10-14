﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Get the mouse position and position basket there
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
	}

    // Check if the eggs hit the basket
    private void OnCollisionEnter(Collision collision) {
        GameObject collideWith = collision.gameObject;
        if (collideWith.tag == "Egg") {
            Destroy(collideWith);
        }
    }
}