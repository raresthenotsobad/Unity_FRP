using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour {

	// Use this for initialization

    public GameObject Player;
    public GameObject Debris;

    public void OnTriggerEnter(Collider hit)
    {
        if ((hit.gameObject.tag == "Player") && (Player.GetComponent<FirstPersonController>().dashing))
       {
        
            Instantiate(Debris, transform.position, transform.rotation);    

            Destroy(gameObject);
        }
    }

	
}
