using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    GameManager gameManager;

    public float spawnTimer = 3.0f;
    private float spawnTime;

    public GameObject enemy;

    public int roundRequirement;

    public GameObject UI;

    public int round = 1;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        round = GameObject.FindGameObjectWithTag("UI").GetComponent<UIManager>().round;
    }

    // Update is called once per frame
    void Update()
    {
                if (roundRequirement == round)
                {
                    if (Time.time > spawnTime)
                    {
                        Instantiate(enemy, transform.position, transform.rotation);

                        spawnTime = Time.time + spawnTimer;
                    }
                }
    }
}