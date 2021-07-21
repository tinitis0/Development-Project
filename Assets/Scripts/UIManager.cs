using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject uiObjEnable;

    // Start is called before the first frame update
    void Start()
    {
        uiObjEnable.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObjEnable.SetActive(true);
            
           // StartCoroutine("WaitTime");
        }
    }

    // IEnumerator WaitTime ()
    // {
    ///     yield return new WaitForSeconds(5);
    //     Destroy(uiObj);
    //    Destroy(gameObject);
    // }
       
}
