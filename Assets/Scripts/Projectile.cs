using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    // Projectile floats
    public float moveSpeed = 500.0f;
    public float lifeTime = 3.0f;

    GameManager gameManager;
    UIManager UI;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        UI = GameObject.FindGameObjectWithTag("UI").GetComponent<UIManager>();
        Destroy(this.gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        transform.position += transform.right * moveSpeed * Time.deltaTime; // Moves the projectile upon instantiation
    }

    // Destroys enemies and projectile upon trigger enter
    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "Enemy")
        {
            UI.score += 1 * UI.round;
            Destroy(otherObject.gameObject);
            Destroy(this.gameObject);
            gameManager.enemiesKilled++;
        }

    }
}
