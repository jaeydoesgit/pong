using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayGame() {

        Application.LoadLevel("Pong");
    }

    public void QuitGame () {

        Application.Quit();
    }

    public void Settings() {

        Application.LoadLevel("SettingsMenu");
    } 
}
