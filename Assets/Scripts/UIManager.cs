using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour{

    public GameManager gameManager;

    // Keeps track of the round and how many enemies defeated
    public Text currentRound;
    public int round;
    public Text enemiesDefeated;

    // Keeps track of the score and time
    public Text timeRemaining;
    public float timer = 300;
    public float score;
    public Text currentScore;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; // Makes the timer go down

        ChangeRound();
        winState();

        // On screen text
        currentScore.text = ("Score: " + score);
        currentRound.text = ("Round:" + round);
        enemiesDefeated.text = ("Enemies Until Next Round: " + gameManager.enemiesKilled + "/5");
        timeRemaining.text = ("Time Remaining: " + Mathf.Round(timer));
    }

    // Changes the round upon a certain amount of enemies being defeated, when a round changes a new enemy spawner activates
    void ChangeRound()
    {
        if (gameManager.enemiesKilled == 5)
        {
            round ++;
            gameManager.enemiesKilled -= 5;
        }
    }

    // Player wins when timer reaches 0
    void winState()
    {
        if(timer <= 0)
        {
            Application.LoadLevel("win");
        }
    }
}
