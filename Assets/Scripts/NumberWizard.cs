using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max = 1000;
	int min = 1;
	int guess = 500;

	void Start () {
		max = max + 1;
		print ("Welcome to Number Wizard");
		print ("Pick a number between " + min + " and " + max + ", but don't tell me!");

		print ("Is the number higher, lower, or equal to " + guess + "?");
		print ("Up = higher, down = lower, return = equal");
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			print ("Number is higher than " + guess + ".");
			min = guess;
			guess = (max + min) / 2;
			print ("Now is your number higher or lower than " + guess + "?");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Number is lower than " + guess + ".");
			max = guess;
			guess = (max + min) / 2;
			print ("Now is your number higher or lower than " + guess + "?");
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Your number is " + guess + ". I won!");
		} 
	}
}
