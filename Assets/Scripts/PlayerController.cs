using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator playerAnim;
    public CharacterController controller;
    public float speed = 4f;

    void Awake()
    {
        playerAnim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(verticalInput, 0, -horizontalInput).normalized;

        if (direction.magnitude >=0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0);
            controller.Move(direction * speed);
            playerAnim.SetBool("isWalk", true);
        }
        else
        {
            playerAnim.SetBool("isWalk", false);
        }
        


    }
}
