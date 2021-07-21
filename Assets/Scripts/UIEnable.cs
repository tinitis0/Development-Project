using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEnable : MonoBehaviour
{   
    public GameObject uiObjEnable;

    private void OnTriggerEnter(Collider UI)
    {
        if (UI.gameObject.tag == "Player")
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


