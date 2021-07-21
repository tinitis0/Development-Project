using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Level_1"); // Load Level 1
    }

    public void LoadLevel()
    {

    }
    
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial"); // Load tutorial level
    }

    public void QuitGame()
    {
        Application.Quit(); // Quits the game
    }
    
}
