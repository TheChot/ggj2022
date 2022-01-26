using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed = 10f;
    float moveInput;
    public float jumpForce = 5f;
    public bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        if(canMove)
        {
            // Gets move input and affects the velocity
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
            
            // Jump controls
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
            // Flip character
            if (moveInput < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                
            }
            else if (moveInput > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
                
            }
        }
    }
}
