using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellOpen : MonoBehaviour
{
    public bool Open = false;
    public Collider coll;
    public GameObject UIText;
    public GameObject cellDoor;
    private Animator doorOpen = null;

    // Start is called before the first frame update
    void Start()
    {
        doorOpen = GetComponent<Animator>();
        UIText.SetActive(false);
        
    }

    public void OpenCell(GameObject obj)
    {
        if (!Open)
        {
            PlayerManager manager = obj.GetComponent<PlayerManager>();
            if (manager)
            {
                if (manager.keyCount > 0)
                {
                    Open = true;
                    manager.UseKey();                   
                    Debug.Log("Door is open");
                    doorOpen.SetBool("isOpen", true);
                    Destroy(coll.gameObject.GetComponent<Collider>());
                    DestroyUI();
                    //cellDoor.transform.position += new Vector3(0, 5, 0);
                }
            }
        }

    }

    public void DestroyUI()
    {
        UIText.SetActive(false);
    }
}
