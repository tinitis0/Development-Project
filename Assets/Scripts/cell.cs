using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell : MonoBehaviour
{

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

        Debug.Log("Door is open");
        Destroy(coll.gameObject.GetComponent<Collider>());
        DestroyUI();
        doorOpen.SetBool("IsOpen", true);
        //cellDoor.transform.position += new Vector3(0, 5, 0);


    }

    public void DestroyUI()
    {
        UIText.SetActive(false);
    }
}