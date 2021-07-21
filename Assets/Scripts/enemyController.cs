using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyController : MonoBehaviour
{
    //Set public reference for look radius can be changed in inspector
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;
    
    //Called on start
    void Start()
    {
        //target to follow
       ///////////////////////////////////////////////////////////////////// target = PlayerManager.instance.player.transform;
        //gets the reference for nav mesh agent component
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //Distance to the player
        float distance = Vector3.Distance(target.position, transform.position);
        //if player is within look radius
        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);

            //Check if agent is equal or closeer than stopping distance
            if (distance <= agent.stoppingDistance)
            {
                //Face the target
                FaceTarget();
            }
        }
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 9f);
    }


    //Draw the gizmos for view distance
    void OnDrawGizmosSelected()
    {
        //set color for gizmos
        Gizmos.color = Color.red;
        //draw the shape for gizmos
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

}
