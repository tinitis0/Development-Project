using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    // Variable
    [SerializeField] private float mouseSensitivity; // set mouse sensativity in inspector

    //References
    private Transform player; // gets player transform

    // Start is called before the first frame update
    private void Start()
    {
        player = transform.parent; // set player transform to be parent for camera
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor so it disapears when game is played
    }

    // Update is called once per frame
    private void Update()
    {
        Rotate(); // call rotate function
    }

    // Rotate the camera
    private void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; // sets mouseX to get the mouse position on x axis and times it by the sensativity and time
        player.Rotate(Vector3.up, mouseX); // rotates player around Y axis
    }  
}
