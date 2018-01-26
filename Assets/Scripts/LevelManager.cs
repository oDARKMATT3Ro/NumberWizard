using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name) {
        Debug.Log("Start game requested for: "+name+".");
        Application.LoadLevel(name);
    }

    public void QuitRequest(){
        Debug.Log("Quit game requested for: "+name+".");
        Application.Quit();
    }
}