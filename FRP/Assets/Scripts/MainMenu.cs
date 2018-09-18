using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public GameObject drop;
    int dropdown_index;
    
    public void QuitGame()
    {
        Debug.Log("The application has ended.");
        Application.Quit();
    }
	public void PlayGame () 
    {
        Dropdown DrowpownMenu = drop.GetComponent<Dropdown>();
        dropdown_index = DrowpownMenu.value;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + dropdown_index + 1 );
	}

}
    