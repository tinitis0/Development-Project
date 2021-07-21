using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    public static bool UIActive = false;
    public GameObject uiText;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnTriggerEnter(Collider other)
     {        
      
        
        if (other.tag == "Player")
        {
            uiText.SetActive(true);
        }
        else
        {
            uiText.SetActive(false);
        }

    }


}
