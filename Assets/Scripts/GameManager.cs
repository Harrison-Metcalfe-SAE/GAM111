using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public bool gamePause = false;
    public int enemiesKilled = 0;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
		Pause ();
	}

	void Pause(){
        if (Input.GetKey("p"))
        {
            Time.timeScale = 0;
            gamePause = true;
        }
        else if (gamePause == true)
        {
            if (Input.GetKey("p")) { }
            Time.timeScale = 1;
            }
        }
	}
