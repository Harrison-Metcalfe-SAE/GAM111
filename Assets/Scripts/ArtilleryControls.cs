using UnityEngine;
using System.Collections;

public class ArtilleryControls : MonoBehaviour{

    public float rotationSpeed = 10.0f;

    public GameObject launcher;

    public float damage = 100.0f;

    // Cannon Controls
    public GameObject muzzle;
    public GameObject cannonBall;

    public GameObject UI;
    public float currentTime;
    public float bestTime;

    public float currentScore;
    public float bestScore;

    // Use this for initialization
    void Start()
    {
        bestScore = PlayerPrefs.GetFloat("Best Score");
    }

    // Update is called once per frame
    void Update()
    {

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

    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "Enemy")
        {
            Application.LoadLevel("lose");
            PlayerPrefs.SetFloat("Current Time", currentTime);
            PlayerPrefs.SetFloat("Current Score", currentScore);
            if (currentTime <= bestTime)
            {
                bestTime = currentTime;
                PlayerPrefs.SetFloat("Best Time", bestTime);
            }
            if (currentScore >= bestScore)
            {
                bestScore = currentScore;
                PlayerPrefs.SetFloat("Best Score", bestScore);
            }
        }
    }
}

