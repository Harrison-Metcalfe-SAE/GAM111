using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ResetMenuController : MonoBehaviour {

    public Button startButton; // Restarts the game

    // Variables for the time records on lose screen
    public float currentTime;
    public Text yourTime;
    public float bestTime;
    public Text recordTime;

    // Variables for the score records on lose screen
    public float yourScore;
    public Text scoreYour;
    public float bestScore;
    public Text scoreBest;
    
	// Use this for initialization
	void Start () {
        // Aquires the best time and scores from player prefs as well as the player's current score and time
        currentTime = PlayerPrefs.GetFloat("Current Time");
        bestTime = PlayerPrefs.GetFloat("Best Time");
        yourScore = PlayerPrefs.GetFloat("Current Score");
        bestScore = PlayerPrefs.GetFloat("Best Score");

        // Lose screen text 
        yourTime.text = ("Your Time Was: " + Mathf.Round(currentTime));
        recordTime.text = ("The Record Time Is: " + Mathf.Round(bestTime));
        scoreYour.text = ("Your Score Was: " + yourScore);
        scoreBest.text = ("The Best Score Is: " + bestScore);
    }
	
	// Update is called once per frame
	void Update () {

	}
}
