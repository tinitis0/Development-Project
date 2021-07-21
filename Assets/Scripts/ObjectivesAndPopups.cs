using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ObjectivesAndPopups : MonoBehaviour
{


    public UnityEvent action; // action when object is interacted with
    public GameObject UIText;
    public GameObject UIText2;
    public GameObject UIText3;    
   
    

    // Start is called before the first frame update
    void Start()
    {
        UIText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // if game object with player tag on it collides with this object
        {                     
            UIText.SetActive(true);
            UIText3.SetActive(false);
        }
        

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // if game object with player tag on it doesnt collides with this object anymore
        {            
            UIText.SetActive(false);
            DestroyArea();
            UIText2.SetActive(true);
        }

    }

    public void DestroyUI()
    {
        UIText.SetActive(false);
    }

    

    public void DestroyArea()
    {                
        Destroy(gameObject);
    }

}
