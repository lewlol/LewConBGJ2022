using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float JumpSpeed;
    public float maxJumpSpeed;


    private void Start()
    {
        maxJumpSpeed = 10.0f;
    }

    private void Update()
    {
        //Jumping
        if (Input.GetButton("Jump"))
        {
            if(JumpSpeed < maxJumpSpeed)
            {
                JumpSpeed += 0.01f;
            }
        }
        if (Input.GetButtonUp("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, JumpSpeed), ForceMode2D.Impulse);
        }

        //Rotating
        var movement = Input.GetAxis("Horizontal");
        if (!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
    }
}
