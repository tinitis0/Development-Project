using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    //Variables

    [SerializeField] private float moveSpeed; // movement speed
    [SerializeField] private float walkSpeed; // walking speed
    [SerializeField] private float runSpeed; // running speed
    private Vector3 moveDirection; // movement direction
    private Vector3 velocity; // gravity velocity

    public float distanceGround;   
    public bool isGrounded = false;
    [SerializeField] private float gravity; // create gravity
    [SerializeField] private float jumpHeight;

    //References
    private CharacterController characterController; // set character controller reference
    private Animator animator; // set animator reference

 

    // Start is called before the first frame update
    private void Start()
    {
        characterController = GetComponent<CharacterController>(); // finds the character controller reference on the same object with the script on it
        animator = GetComponentInChildren<Animator>();
        distanceGround = GetComponent<Collider>().bounds.extents.y;

    }
    // Update is called once per frame
    private void Update()
    {
        Move(); // calls Move function
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
            Debug.DrawLine(ray.origin, hit.point);      
    }
    // Move function 
    private void Move()
    {

        if (!Physics.Raycast(transform.position, -Vector3.up, distanceGround + 0.1f))
        {
            isGrounded = false;
        }
        else
        {
            isGrounded = true;
        }

        float moveZ = Input.GetAxis("Vertical"); // Z axis is forward and backwards 
        float moveX = Input.GetAxis("Horizontal"); // X axis is left and right 

        moveDirection = new Vector3(moveX, 0, moveZ); // sets the movement direction to moveZ amount
        moveDirection = transform.TransformDirection(moveDirection); //sets the forward direction to be direction player is looking at        

   
        if (moveDirection == Vector3.forward && !Input.GetKey(KeyCode.LeftShift)) // if move Direction is not equal to 0,0,0 and not pressing Left shift then Walk
            {
                //Walk
                Walk();
            }
        else if (moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift)) // if move Direction is not equal to 0,0,0 and Left shift is pressed then Run
        {
                //Run
                Run();
        }
         else if (moveDirection == Vector3.zero) // if move Direction is  equal to 0,0,0 then character is Idle
         {
              //Idle
                Idle();
         }

            moveDirection *= moveSpeed; // multiply moveDirection to moveSpeed set in above if statement

            if (Input.GetKeyDown(KeyCode.Space)) // if Space key is pressed down the call jump function
            {
                Jump(); // call jump function 
                animator.SetBool("Jump", true);
            }
            else
            {
                animator.SetBool("Jump", false);
            }

        characterController.Move(moveDirection * Time.deltaTime); // times the movement direction to make sure character moves no matter how many frames
        velocity.y += gravity * Time.deltaTime; // calculate gravity for player character
        characterController.Move(velocity * Time.deltaTime); // apply gravity to the player 

    }

    //Idle function
    private void Idle()
    {
        animator.SetFloat("Speed", 0, 0.2f, Time.deltaTime);
    }
    // Run function 
    private void Run()
    {
        moveSpeed = runSpeed;
        animator.SetFloat("Speed", 1, 0.2f, Time.deltaTime);
    }
    // Walk function
    private void Walk()
    {
        moveSpeed = walkSpeed;
        animator.SetFloat("Speed", 0.5f, 0.2f, Time.deltaTime);

    }
    // Jump function
    private void Jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity); // calculate the jump
       
    }
    
}
