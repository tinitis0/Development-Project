using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDisable : MonoBehaviour
{
    public GameObject uiObjDisable;
       
    private void OnTriggerEnter(Collider UI)
    {
        if (UI.gameObject.tag == "Player")
        {
            uiObjDisable.SetActive(false);
            Destroy(uiObjDisable);
            Destroy(gameObject);

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
