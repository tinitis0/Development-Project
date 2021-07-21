using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public bool dead = false;
    public GameObject DeathMenuUI;

    public static bool UIActive = false;
    public GameObject uiText;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (dead)
        {
           Dead();
        }
        else
        {
            dead = false;
        }

        //if (Input.GetKeyDown(KeyCode.L))
        //{
        //    if (UIActive)
        //    {
        //        Disable();
        //    }
        //    else if (!UIActive)
        //    {
        //        Enable();
        //    }
        //
        //}
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        A();
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        B();        
    }

    public void A()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void B()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Dead()
    {
        DeathMenuUI.SetActive(true);
        dead = true;
        B();
    }

    public void NotDead()
    {
        DeathMenuUI.SetActive(false);       
        dead = false;        
        A();
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void QuitGame()
    {
        Application.Quit();
    }


    public void RespawnPlayer()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        NotDead();
    }

    public void Disable()
    {
        uiText.SetActive(true);
    }

    public void Enable()
    {
        uiText.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            dead = true;
        }

    }
}
