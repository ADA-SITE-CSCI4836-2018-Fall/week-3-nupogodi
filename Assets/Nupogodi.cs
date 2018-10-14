using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nupogodi : MonoBehaviour {

    public GameObject basketPrefab;
    public int basketNumber = 3;
    public float basketBottomY = -4f;
    public float basketSpaceY = 0.7f;

	// Use this for initialization
	void Start () {
        // Instantiate number of baskets 
        Vector3 pos = Vector3.zero;
        for (int i=0; i<basketNumber; i++) {
            GameObject aBasket = Instantiate(basketPrefab);
            pos.y = basketBottomY + i * basketSpaceY;
            aBasket.transform.position = pos;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
