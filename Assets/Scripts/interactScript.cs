using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class interactScript : MonoBehaviour
{

    public bool isInRange; // sets to default = false
    public KeyCode interactKey; // key thats pressed to interact with objects
    public UnityEvent interactAction; // action when object is interacted with
    public GameObject uiText;

    void Start()
    {
        uiText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange) // if in tange to interact
        {
            if (Input.GetKeyDown(interactKey)) // and player presses the interact key
            {
                interactAction.Invoke(); // fires all functions on the event
                Debug.Log("Player is interacting");
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // if game object with player tag on it collides with this object
        {
            isInRange = true; // changes is in range bool to be true
            Debug.Log("Player is in Range"); // logs out a message
            uiText.SetActive(true);           
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // if game object with player tag on it doesnt collides with this object anymore
        {
            isInRange = false; // changes is in range bool to be false
            Debug.Log("Player is not in Range"); // logs out a message
            uiText.SetActive(false);
        }
    }

    public void DestroyUI()
    {
        uiText.SetActive(false);
    }
}
