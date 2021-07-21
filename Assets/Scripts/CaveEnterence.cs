using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CaveEnterence : MonoBehaviour
{
    public bool isOpen;
    

    public void EnterCave()
    {        
        Debug.Log("EnterCave");
        SceneManager.LoadScene("Main Menu");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void EnterPortal()
    {
        Debug.Log("EnterPortal");
        SceneManager.LoadScene("Level_1");
    }

}
