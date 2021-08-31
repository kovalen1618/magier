using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene("Level1");
        Debug.Log("I am Being CLicked!@!");
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }    
}

