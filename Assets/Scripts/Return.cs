using UnityEngine;
using System.Collections;

public class Return : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Return to main menu
    public void returnToMenu()
    {
        Application.LoadLevel("menu");
    }
}
