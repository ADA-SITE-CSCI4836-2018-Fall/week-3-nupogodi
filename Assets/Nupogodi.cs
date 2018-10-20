using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nupogodi : MonoBehaviour {

    public GameObject basketPrefab;
    public int basketNumber = 3;
    public float basketBottomY = -4f;
    public float basketSpaceY = 0.7f;

    public List<GameObject> basketList;

	// Use this for initialization
	void Start () {
        // Instantiate number of baskets 
        Vector3 pos = Vector3.zero;
        for (int i=0; i<basketNumber; i++) {
            GameObject aBasket = Instantiate(basketPrefab) as GameObject;
            pos.y = basketBottomY + i * basketSpaceY;
            aBasket.transform.position = pos;
            // Add a new basket to the list
            basketList.Add(aBasket);        
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EggDestroyed() {
        // Destroy all falling eggs
        GameObject[] eggArray = GameObject.FindGameObjectsWithTag("Egg");
        foreach (GameObject anEgg in eggArray)
        {
            Destroy(anEgg);
        }

        // Destroy one basket
        int basketIndex = basketList.Count - 1;
        GameObject aBasket = basketList[basketIndex];
        Destroy(aBasket);
        basketList.RemoveAt(basketIndex);

        // Restart the game if this is the end
        if (basketIndex == 0) {
            SceneManager.LoadScene("_Level_0");
        }
    }
}
