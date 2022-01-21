using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public Animator animator;

    public float moveSpeed = 10f;
    public float jumpForce = 10f;
    public bool isGrounded;
    private SpriteRenderer sprite;

    public void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        Jump();
        float h = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(h, 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        animator.SetFloat("Speed", Mathf.Abs(h));

        if (Input.GetAxis("Horizontal") > 0)
        {
            sprite.flipX = true;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            sprite.flipX = false;
        }

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = (new Vector2(0f, jumpForce));
        }
        
        if (!isGrounded)
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }
    }

    void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
}

