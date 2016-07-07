using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

    public void ButtonStart(){
        Application.LoadLevel("artillery");
    }
}
