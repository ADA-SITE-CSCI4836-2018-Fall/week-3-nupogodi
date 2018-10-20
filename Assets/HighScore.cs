using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    static public int score = 100;
    const string keyName = "NuPogodiHighScore";

    // When the instance of this class is first created
    private void Awake() {
        // If there is a value stored in player preferences
        if (PlayerPrefs.HasKey(keyName)) {
            score = PlayerPrefs.GetInt(keyName);
        }
        // Save the high score in player preferences
        SaveHighScore();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Text highScoreText = this.GetComponent<Text>();
        highScoreText.text = "High Score: " + score + " qəpik";
        if (score > PlayerPrefs.GetInt(keyName)) {
            SaveHighScore();
        }
    }


    public void SaveHighScore() {
        PlayerPrefs.SetInt(keyName, score);
    }
}
