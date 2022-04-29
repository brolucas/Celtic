using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Victoire : MonoBehaviour
{
    void Update()
    {
        
        if(Input.GetAxis("Vertical") > 0)
        {

            SceneManager.LoadScene("Cernunnos_game");
        }
        
        if(Input.GetAxis("Vertical") < 0)
        {
            Application.Quit();
            Debug.Log("quit");

        }
    }

}