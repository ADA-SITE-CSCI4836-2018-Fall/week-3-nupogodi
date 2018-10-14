using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour {
    // Prefab for eggs
    public GameObject prefabEgg;

    // Speed of Chicken movement
    public float speed = 3f;

    // Right or left limit of the movement
    public float limitMovement = 5f;

    // Chance of random change of direction
    public float chanceDirectionChange = 0.01f;

    // Regularity of dropping eggs
    public float secondsBetweenEggDrops = 1f;

	// Use this for initialization
	void Start () {
        InvokeRepeating("DropEgg", 2f, secondsBetweenEggDrops);
	}
	
    // Drop one egg 
    void DropEgg ()
    {
        GameObject egg = Instantiate(prefabEgg);
        egg.transform.position = transform.position;
    }

	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.x = pos.x + speed * Time.deltaTime;
        transform.position = pos;

        if (Mathf.Abs(pos.x) > limitMovement)
        {
            speed = -speed;
        }
	}

    private void FixedUpdate()
    {
        if (Random.value < chanceDirectionChange)
        {
            speed = -speed;
        }
    }
}
