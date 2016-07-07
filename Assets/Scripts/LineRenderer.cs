using UnityEngine;
using System.Collections;

public class LineRenderer : MonoBehaviour {
    
    public float timeResolution = 0.02f;
    public float maxTime = 10.0f;

    private LineRenderer lineRenderer;

    public float tempSpeed = 500.0f;

	// Use this for initialization
	void Start () {
        lineRenderer = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        /*
        Vector3 velocityVector = transform.forward * tempSpeed;

        lineRenderer.SetVertexCount((int)(maxTime/timeResolution));

        int index = 0;

        Vector3 currentPosition = transform.position;

        for (float t = 0.0f; t < maxTime; t += timeResolution) {
            lineRenderer.SetPosition(index, currentPosition);
            currentPosition += velocityVector * timeResolution;
            velocityVector += Physics.gravity * timeResolution;
            index++;
        }
        */
	}
}

