using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Go to credits screen
    public void OpenCredits()
    {
        Application.LoadLevel("Credits");
    }
}
