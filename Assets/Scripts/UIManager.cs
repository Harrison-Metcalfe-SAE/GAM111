using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour{

    public int round;

    public GameManager gameManager;

    public Text currentRound;

    public Text enemiesDefeated;

    public Text timeRemaining;

    public float timer = 500;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        ChangeRound();
        currentRound.text = ("Round:" + round);
        enemiesDefeated.text = ("Enemies Dispatched: " + gameManager.enemiesKilled);
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
}
