using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongerMovingPlatforms : MonoBehaviour {

    public Transform movingPlatform;
    public Vector3 newPosition;
    public float smooth;
    public float resetTime;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("ChangeTarget", 0f, resetTime);
    }

    public Vector3[] Positions;
    int currentPosition;
    void ChangeTarget2()
    {
        currentPosition += 1;

        var destPosition = currentPosition % Positions.Length;
        newPosition = Positions[destPosition];

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime);
    }
}
