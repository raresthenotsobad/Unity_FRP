using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public int Jump_Speed = 5;
    public AudioSource Pad_sound;
	
    public void OnTriggerEnter(Collider col)
    {
		if (col.gameObject.tag == "Player")
		{
			FirstPersonController PlayerScript = col.gameObject.GetComponent<FirstPersonController>();
			Pad_sound.Play();
			//float test = PlayerScript.jumpSpeed + Jump_Speed;
			PlayerScript.verticalVelocity = PlayerScript.jumpSpeed + Jump_Speed;
		}
    }
    

}
    

    /*void OnTriggerEnter(Collider col)
    {
        Debug.Log("fuck");
        GameObject thePlayer = GameObject.Find("Player");
        FirstPersonController PlayerScript = thePlayer.GetComponent<FirstPersonController>();
        PlayerScript.verticalVelocity = PlayerScript.jumpSpeed * Speed;
    }*/

    

