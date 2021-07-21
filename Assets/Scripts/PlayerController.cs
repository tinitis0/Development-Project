using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed; // movement speed
    Animator animator;
    Vector2 input;
    Vector3 direction = Vector3.zero;
    //jumping
    float jumpSpeed = 7f;
    float verticalVelocity = 0;
     public float distanceGround;
    public bool isGrounded = false;

    //CharacterController characterController; // set character controller reference


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();        
        //characterController = GetComponent<CharacterController>(); // finds the character controller reference on the same object with the script on it
        distanceGround = GetComponent<Collider>().bounds.extents.y;
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        animator.SetFloat("InputX", input.x);
        animator.SetFloat("InputY", input.y);

        direction = transform.rotation * new Vector3(input.x, 0, input.y);
        direction *= moveSpeed;
        //jumping

       //if (characterController.isGrounded)
       //{
       //    animator.SetBool("Jumping", false);
       //
       //    if (Input.GetKey(KeyCode.Space))
       //    {
       //        verticalVelocity = jumpSpeed;
       //    }
       //    else
       //    {
       //        verticalVelocity = 0;
       //    }
       //
       //}
       //else
       //{
       //    animator.SetBool("Jumping", true);
       //}

        //
        //if (characterController.isGrounded && Input.GetKey(KeyCode.Space))
        //{
        //    verticalVelocity = jumpSpeed;
        //    animator.SetBool("Jumping", true);
        //}
        //else
        //{
        //    animator.SetBool("Jumping", false);
        //}




    }

    void FixedUpdate()
    {
        Vector3 dist = direction * moveSpeed * Time.deltaTime;


        verticalVelocity += Physics.gravity.y * Time.deltaTime;
        

        dist.y = verticalVelocity * Time.deltaTime;
       // characterController.Move(dist);
        
    }
}
