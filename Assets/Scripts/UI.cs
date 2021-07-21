using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject uiText;

    // Start is called before the first frame update
    void Start()
    {
        uiText.SetActive(false);
    }
    public void OnGUI()
    {        
        //uiText.SetActive(true);
        Debug.Log("EnterCave");
    }
}
