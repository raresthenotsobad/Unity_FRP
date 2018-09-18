using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time_swing : MonoBehaviour {

    public float hittime = 0.0f;
	// Use this for initialization
	void OnTriggerEnter (Collider hit)
    {
        print(hittime);
        hittime = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
    {
        hittime = Time.deltaTime;
	}
}
