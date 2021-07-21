using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public GameObject DeathMenuUI;
    public GameObject objUI;

    public int keyCount; // gets the key count   
    public void PickUpKey() // key pick up function 
    {
        keyCount++; // adds 1 key to the count when function triggered
        Debug.Log("Key picked up");
        
    }

    public void UseKey()
    {
        keyCount--;
        Debug.Log("Key Used");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
           
            DeathMenuUI.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            objUI.SetActive(false);
        }
    }
    public void RespawnPlayer()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        DeathMenuUI.SetActive(false);
        Time.timeScale = 1f; 
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

}  
