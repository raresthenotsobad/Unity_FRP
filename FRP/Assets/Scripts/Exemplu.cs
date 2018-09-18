using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplu : MonoBehaviour {

    public GameObject Pendulum_pusher;
    public int pause_time = 1;

	// Use this for initialization
	void OnTriggerEnter (Collider col)
    {
        StartCoroutine(NoPush());
	}
	
	// Update is called once per frame
	IEnumerator NoPush () 
    {
       BoxCollider pusher = Pendulum_pusher.GetComponent<BoxCollider>();
       pusher.enabled = false;

        yield return new WaitForSeconds(pause_time);

        pusher.enabled = true;
	}
}
