using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public float moveSpeed = 500.0f;
    public float lifeTime = 3.0f;

    GameManager gameManager;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        Destroy(this.gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {

        Movement();
    }

    public void Movement()
    {
        transform.position += transform.right * moveSpeed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "Enemy")
        {
            Destroy(otherObject.gameObject);
            Destroy(this.gameObject);
            gameManager.enemiesKilled++;
        }

    }
}
