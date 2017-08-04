using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;

	void Start () {
		StartGame();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;

		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number between " + min + " and " + max + ", but don't tell me!");

		print ("Is the number higher, lower, or equal to " + guess + "?");
		print ("Up = higher, down = lower, return = equal");

		max = max + 1;
	}

	void NextGuess () {
		guess = (max + min) / 2;
		print ("Now is your number higher or lower than " + guess + "?");
	}

	void WinGame () {
		print ("Your number is " + guess + ". I won!");
		StartGame();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			print ("Number is higher than " + guess + ".");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Number is lower than " + guess + ".");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			WinGame();
		} 
	}
}
