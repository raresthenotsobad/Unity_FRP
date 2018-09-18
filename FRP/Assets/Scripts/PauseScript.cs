using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class PauseScript : MonoBehaviour
{
   // public Transform canvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || (Input.GetKeyDown(KeyCode.Escape)))
        {
			
			SceneManager.LoadScene(0);
           /* if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
                Cursor.visible = true;
                Time.timeScale = 0;
            }
            else if (canvas.gameObject.activeInHierarchy == true)
            {
                canvas.gameObject.SetActive(false);
                Cursor.visible = false;
                Time.timeScale = 1;
            }*/
        }
    }
}
