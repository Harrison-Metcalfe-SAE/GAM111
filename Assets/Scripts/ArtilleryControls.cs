using UnityEngine;
using System.Collections;

public class ArtilleryControls : MonoBehaviour{

    // Cannon Specifications
    public GameObject launcher;

    // Cannon Controls
    public GameObject muzzle;
    public GameObject cannonBall;
    public float rotationSpeed = 10.0f;

    // Score tracking systems
    public GameObject UI;
    public float currentTime;
    public float bestTime;
    public float currentScore;
    public float bestScore;

    // Use this for initialization
    void Start()
    {
        bestScore = PlayerPrefs.GetFloat("Best Score"); // Aquires the best score stored in playerprefs
    }

    // Update is called once per frame
    void Update()
    {
        // Takes the current in game time and score from the UIManager
        currentTime = UI.GetComponent<UIManager>().timer;
        currentScore = UI.GetComponent<UIManager>().score;

        //Up and Down Rotation
        if (Input.GetKey("w"))
        {
            launcher.transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("s"))
        {
            launcher.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }

        //Left and Right Rotation
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

        FireCannon();
    }

    // Cannon Fire
    void FireCannon()
    {
        if (Input.GetKeyDown("space")){
            Instantiate(cannonBall, muzzle.transform.position, muzzle.transform.rotation);
        }
    }

    // Lose Condition
    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "Enemy")
        {
            Application.LoadLevel("lose");
            PlayerPrefs.SetFloat("Current Time", currentTime); // Sets the player pref current time for use in the lose screen
            PlayerPrefs.SetFloat("Current Score", currentScore); // Sets the player pref current score for use in the lose screen

            // If the player's current time is better than the record, replace the record in player prefs
            if (currentTime <= bestTime) 
            {
                bestTime = currentTime;
                PlayerPrefs.SetFloat("Best Time", bestTime);
            }

            // If the player's current score is better than the record, replace the record in player prefs
            if (currentScore >= bestScore)
            {
                bestScore = currentScore;
                PlayerPrefs.SetFloat("Best Score", bestScore);
            }
        }
    }
}

