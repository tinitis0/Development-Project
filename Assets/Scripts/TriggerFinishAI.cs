using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.UI;

public class TriggerFinishAI : MonoBehaviour
{

    public Component script;
    public Component script2;
    public Rigidbody rb;
    public Animator anim;

    public GameObject UIText;
    public GameObject UIText2;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            anim.GetComponent<Animator>().enabled = false;
            script.GetComponent<AICharacterControl>().enabled = false;
            script2.GetComponent<ThirdPersonCharacter>().enabled = false;

            rb.isKinematic = true;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.constraints = RigidbodyConstraints.FreezeAll;


            anim.ResetTrigger("Idle");
            
                UIText.SetActive(false);
                UIText2.SetActive(true);
            
        }

    }
}
