using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUps : MonoBehaviour
{

    public GameObject[] popUps;
    private int popUpIndex;
    public float waitTime = 2f;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
        }

        if (popUpIndex == 0)
        {
            if (waitTime <= 0)
            {
                if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
                {
                    popUpIndex++;
                }                
            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }
            else if (popUpIndex == 1)
            {
               if (Input.GetKeyDown(KeyCode.E))
               {
                    popUpIndex++;
               }
            }
            else if (popUpIndex == 2)
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    popUpIndex++;
                }
            }
            else if (popUpIndex == 3)
            {
                if (Input.GetKeyDown(KeyCode.L))
                {
                    popUpIndex++;
                }
            }


    }
    

}
