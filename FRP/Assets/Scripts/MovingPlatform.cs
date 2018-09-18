using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public Transform movingPlatform;
    public Transform Position1;
    public Transform Position2;
    public Vector3 newPosition;
    public string currentState;
    public float smooth;
    public float resetTime;


	// Use this for initialization
	void Start () 
    {
        ChangeTarget();	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime);	
	}

    void ChangeTarget()
    {
        if (currentState == "Moving to Position 1")
        {
            currentState = "Moving to Position 2";
            newPosition = Position2.position;
        }
        else if(currentState == "Moving to Position 2")
        {
            currentState = "Moving to Position 1";
            newPosition = Position1.position;
        }
        else if (currentState == "")
        {
            currentState = "Moving to Position 2";
            newPosition = Position2.position;
        }
        Invoke("ChangeTarget", resetTime);
    }
}
