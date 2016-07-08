using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

    // Start the game
    public void ButtonStart(){
        Application.LoadLevel("artillery");
    }
}
