using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour {

	// Use this for initialization

	private string combination;
	private string [] combos;

	void addToCombination(string key){
		combination += key;
	}

	void resetCombination(){
		combination = "";
	}

	string getCombination(){
		return combination;
	}


	void Start () {
		combos = new string[] { 
			"RU", "RR", "RD",
			"LU", "LR", "LD",
			"UU", "DD",
			"UDRU", "UDRR", "UDRD"
		};
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			addToCombination("U");
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			addToCombination("D");
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			addToCombination("L");
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			addToCombination("R");
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (Array.IndexOf(combos, getCombination()) != -1){
				Debug.Log(getCombination() + " : OK");
			} else {
				Debug.Log(getCombination() + " : DUPA");
			} 
			resetCombination();
		}

	}
}
