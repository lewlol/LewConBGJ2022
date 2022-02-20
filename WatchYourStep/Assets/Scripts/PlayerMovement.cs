using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float JumpSpeed;
    public float sideSpeed;
    public float minSideSpeed;
    public float maxSideSpeed;
    public float maxJumpSpeed;

    public bool resetSpeed;

    public SpriteRenderer sr;

    public Sprite jump;
    public Sprite charge;

    public GameObject groundParticles;


    private void Start()
    {
        maxJumpSpeed = 10.0f;
        minSideSpeed = -10.0f;
        maxSideSpeed = 10.0f;
    }

    private void Update()
    {
        //Jumping
        if (Input.GetButton("Jump"))
        {
            if(JumpSpeed < maxJumpSpeed)
            {
                JumpSpeed += 0.01f;
                sr.sprite = charge;
            }
            if (JumpSpeed >= maxJumpSpeed && resetSpeed == true)
            {
                groundParticles.SetActive(true);
            }
        }
        if (Input.GetButtonUp("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(sideSpeed, JumpSpeed), ForceMode2D.Impulse);
            sr.sprite = jump;
            groundParticles.SetActive(false);
        }

        //Sideways Movement
        if (Input.GetKey(KeyCode.A))
        {
            if(sideSpeed > minSideSpeed)
            {
                sideSpeed -= 0.01f;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if(sideSpeed < maxSideSpeed)
            {
                sideSpeed += 0.01f;
            }
        }

        //Rotating
        var movement = Input.GetAxis("Horizontal");
        if (!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            if (!resetSpeed)
            {
                JumpSpeed = 0;
                sideSpeed = 0;
                resetSpeed = true;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            resetSpeed = false;
        }
    }
}
