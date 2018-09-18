using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour {

    [SerializeField] private Transform respawnpoint;
    public AudioSource Respawn_sound;

	void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Player")
        {
           // Scene Scene = SceneManager.GetActiveScene();
           // SceneManager.LoadScene(Scene.name);
            other.gameObject.transform.position = respawnpoint.position;
            Respawn_sound.Play();

        }
        //if (other.gameObject.tag == "Player")
        //{
      //      SceneManager.LoadScene("GameOver");
       // }
    }
}
