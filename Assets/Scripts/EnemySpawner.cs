using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    GameManager gameManager;

    // Enemy spawning var
    public float spawnTimer = 3.0f;
    private float spawnTime;
    public GameObject enemy;

    public int roundRequirement; // Used to check if the spawner should spawn enemy

    public GameObject UI; // Used to aquire the round

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
        // Checks if the round requirement is correct and enables the spawner if it is
        round = GameObject.FindGameObjectWithTag("UI").GetComponent<UIManager>().round;
        if (roundRequirement <= round)
                {
                    if (Time.time > spawnTime)
                    {
                        Instantiate(enemy, transform.position, transform.rotation);

                        spawnTime = Time.time + spawnTimer;
                    }
                }
    }
}