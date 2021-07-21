using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementV2 : MonoBehaviour
{

    private CharacterController characterController;
    private Animator animator;

    [SerializeField]
    private float moveSpeed = 10;
    [SerializeField]
    private float turnSpeed = 100f;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizantal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var movement = new Vector3(horizantal, 0, vertical);

        animator.SetFloat("Speed", vertical);
        transform.Rotate(Vector3.up, horizantal + turnSpeed * Time.deltaTime);

        if (vertical != 0)
        {
            characterController.SimpleMove(transform.forward * moveSpeed * vertical);
        }

        Ray ray = Camera.main.ViewportPointToRay(Vector3.one * 0.5f);
        Debug.DrawLine(ray.origin, ray.direction * 100, Color.red, 2f);


    }
}
