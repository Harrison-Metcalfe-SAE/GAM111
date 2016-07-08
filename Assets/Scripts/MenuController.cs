using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public Button startButton;

    public float currentTime;

    public Button creditsButton;

	// Use this for initialization
	void Start () {
        currentTime = PlayerPrefs.GetFloat("Current Time");
    }
	
	// Update is called once per frame
	void Update () {

	}
}
