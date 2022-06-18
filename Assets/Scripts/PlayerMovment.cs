using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    // Global Variables

    // Controlling the player speed
    [SerializeField] private float speed = 5.0f;

    // Forward & Backward movement
    private float forwardInput;

    // Left & Right movement
    private float horizontalInput;

    // Rotation speed
    [SerializeField] private float rotationSpeed = 270.0f;

    // How high the player can jump
    [SerializeField] private float jumpForce = 5.0f;

    // Declare the rigid body
    private Rigidbody playerRb;

    // Check if the player is on the ground
    public bool isOnGround = true;

    public bool isWalking = false;

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        // Access the rigid body
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Camera following the player
       // followCamera.transform.position = playerRb.position + m_CameraPos;

        // Get player input
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the player
        Vector3 movmentDirection = new Vector3(horizontalInput, 0, forwardInput);
        movmentDirection.Normalize();

        // change the position based on the movement direction
        transform.Translate(movmentDirection * speed * Time.deltaTime,Space.World);

        // Check if the player is moving
        if (movmentDirection != Vector3.zero)
        {
            // if its moving we want the player to rotate to face the direction its moving
            // Store rotations
            Quaternion toRotation = Quaternion.LookRotation(movmentDirection,Vector3.up);

            // Change the rotation of the player
            transform.rotation = Quaternion.RotateTowards(transform.rotation,toRotation,rotationSpeed * Time.deltaTime);

        }

        // Animations
        animator.SetBool("isWalking", Input.GetAxisRaw("Vertical") != 0);

        // Let the player jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
