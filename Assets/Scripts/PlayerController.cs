using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator playerAnim;
    private Rigidbody playerRb;
    private bool isWalk = false;
    private float horizontalInput;
    private float verticalInput;
    public float walkSpeed = 2f;
    public float rotationSpeed = 200f;

    void Awake()
    {
        playerAnim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        playerRb.AddForce(Vector3.forward * walkSpeed * verticalInput);
        transform.Rotate(Vector3.up, rotationSpeed * horizontalInput);


    }
}
