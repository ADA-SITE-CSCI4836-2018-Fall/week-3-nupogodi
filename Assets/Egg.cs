using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour {
    // Bottom limit for eggs
    public float bottomLimit = -10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomLimit)
        {
            Destroy(this.gameObject);
        }
	}
}
