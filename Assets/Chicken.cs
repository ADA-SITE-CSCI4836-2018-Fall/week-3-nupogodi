using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour {
    // Speed of Chicken movement
    public float speed = 3f;

    // Right or left limit of the movement
    public float limitMovement = 4f;

    // Chance of random change of direction
    public float chanceDirectionChange = 0.01f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.x = pos.x + speed * Time.deltaTime;
        transform.position = pos;

        if (Mathf.Abs(pos.x) > limitMovement)
        {
            speed = -speed;
        } else if (Random.value < chanceDirectionChange)
        {
            speed = -speed;
        }
	}
}
