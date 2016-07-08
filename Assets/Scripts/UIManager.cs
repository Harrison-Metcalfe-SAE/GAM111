using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour{

    public int round;

    public GameManager gameManager;

    public Text currentRound;

    public Text enemiesDefeated;

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
        timer -= Time.deltaTime;
        ChangeRound();
        winState();
        currentScore.text = ("Score: " + score);
        currentRound.text = ("Round:" + round);
        enemiesDefeated.text = ("Enemies Until Next Round: " + gameManager.enemiesKilled + "/5");
        timeRemaining.text = ("Time Remaining: " + Mathf.Round(timer));
    }

    void ChangeRound()
    {
        if (gameManager.enemiesKilled == 5)
        {
            Debug.Log("Is it working?");
            round ++;
            gameManager.enemiesKilled -= 5;
        }
    }

    void winState()
    {
        if(timer <= 0)
        {
            Application.LoadLevel("win");
        }
    }
}
