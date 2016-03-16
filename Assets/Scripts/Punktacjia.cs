using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Punktacjia : MonoBehaviour {
    Text text;
    public static int score;
	// Use this for initialization
	void Awake ()
    {
        text = GetComponent<Text>();

        score = 0;
    }
	// Update is called once per frame
	void UpdateScore () {
        text.text = "Score: " + score;
	
	}
}
