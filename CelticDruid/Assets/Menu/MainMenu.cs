using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if(Input.GetAxis("Vertical") > 0)
        {

            SceneManager.LoadScene("");
        }
        
        if(Input.GetAxis("Vertical") < 0)
        {
            Application.Quit();
            Debug.Log("quit");

        }
    }

}
