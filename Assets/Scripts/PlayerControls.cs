using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Animator animator;
    public float speed = 20f;

    private float horizontalMovement;
    private Rigidbody2D rBody2D;
    private Vector3 velocity = Vector3.zero;

    private SpriteRenderer spriteRenderer2D;

    private bool isLookingRight = true;

    private void Awake()
    {
        rBody2D = GetComponent<Rigidbody2D>();
        spriteRenderer2D = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal") * speed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));
        //invert player by direction
        if (horizontalMovement>0)
        {
            spriteRenderer2D.flipX = true;
        }
        else if (horizontalMovement < 0)
        {
            spriteRenderer2D.flipX = false;
        }

    }

    private void FixedUpdate()
    {
        Move(horizontalMovement * Time.fixedDeltaTime);
    }

    public void Move(float move)
    {
        Vector3 targetVelocity = new Vector2(move * 10f, rBody2D.velocity.y);
        rBody2D.velocity = Vector3.SmoothDamp(rBody2D.velocity, targetVelocity, ref velocity, 0.05f);
    }
}
