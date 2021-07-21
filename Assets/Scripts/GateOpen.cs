using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    public bool isOpen = false;
    public Collider coll;
    private Animator doorOpen = null;
    public GameObject uiText;

    // Start is called before the first frame update
    void Start()
    {
        doorOpen = GetComponent<Animator>();
        uiText.SetActive(false);
    }

   public void OpenDoor(GameObject obj)
   {
       if (!isOpen)
       {
           PlayerManager manager = obj.GetComponent<PlayerManager>();
           if (manager)
           {
               if (manager.keyCount > 0)
               {
                   isOpen = true;
                   manager.UseKey();
                   doorOpen.SetBool("IsOpen", true);
                   Debug.Log("Door is open");
                   Destroy(coll.gameObject.GetComponent<Collider>());
                   DestroyUI();
               }
           }
       }   
   
   }

    public void DestroyUI()
    {
        uiText.SetActive(false);
    }
}
