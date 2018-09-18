using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour {

    public float torque;
    public Rigidbody rb;
    public int dir = 1;
    public int pause_time = 5;
	void Start () 
    {
        rb = GetComponent<Rigidbody>();	
	}
	
    void OnTriggerEnter(Collider col)
    {
        //StartCoroutine(noPush());
        if (col.gameObject.tag == "effect")
		{
			dir = dir * (-1);
		}
    }

	// Update is called once per frame
	void OnTriggerStay(Collider other) 
	{	
		rb.AddTorque(transform.right * torque * dir);
	}

    IEnumerator noPush()
    {
        dir = dir * (-1);

        yield return new WaitForSeconds(pause_time);

        dir = 0;
    }
}
