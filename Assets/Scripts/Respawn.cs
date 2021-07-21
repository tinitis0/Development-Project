using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : pauseMenu
{
    //bool dead = false;
    //public GameObject DeathMenuUI; 
       
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            dead = true;
        }
           
    }

   // public void RespawnPlayer()
   // {
   //       
   //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   //     NotDead();
   // }
   //
   // public void Update()
   // {
   //
   //     if (dead)
   //     {
   //         //yield return StartCoroutine(WaitASec(4f));
   //         //StartCoroutine(Wait());
   //         
   //         Dead();            
   //     }
   //     else
   //     {
   //         
   //         NotDead();
   //     }
   // }
   // public void Dead()
   // {
   //     DeathMenuUI.SetActive(true);
   //     //Time.timeScale = 0f;
   //     dead = true;
   //     Cursor.visible = true;
   //     Cursor.lockState = CursorLockMode.None;
   //     
   // }
   //
   // public void NotDead()
   // {
   //     DeathMenuUI.SetActive(false);
   //    // Time.timeScale = 1f;
   //     dead = false;
   //     Cursor.visible = false;
   //     Cursor.lockState = CursorLockMode.Locked;
   // }

    //IEnumerator Wait()
    //{
    //    Debug.Log("Started Coroutine at timestamp : " + Time.time);
    //    yield return new WaitForSeconds(2);
    //    Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    //}

}
