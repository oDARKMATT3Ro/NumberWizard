using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int max = 1000;
		int min = 1;


		print ("Welcome to Number Wizard");
		print ("Pick a number between " + min + " and " + max + ", but don't tell me!");

		print ("Is the number higher or lower than 500?");
		print ("Up = higher, down = lower, return = equal");
	}

	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Debug.Log ("Up arrow pressed");
			print ("Number is higher than 500.");
		} 

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log ("Down arrow pressed");
			print ("Number is lower than 500.");
		}

		if (Input.GetKeyDown (KeyCode.Return)) {
			Debug.Log ("Return key pressed");
			print ("Your number is 500!!");
		}
	}
}
