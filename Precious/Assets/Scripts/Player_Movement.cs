using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private float Horizontal;
    private float Speed = 8f;
    private float JumpPower = 10f;
    private bool FacingRight = true;

    [SerializeField] private Rigidbody2D r2d;
    [SerializeField] private Transform groundcheck;
    [SerializeField] private LayerMask Groundlayer;

    public Animator animate;

    private void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        animate.SetFloat("Speed", Mathf.Abs(Horizontal));

        if (Input.GetButtonDown("Jump") && Grounded())
        {
            r2d.velocity = new Vector2(r2d.velocity.x, JumpPower);
        }

        if (Input.GetButtonDown("Jump") && r2d.velocity.y > 0f)
        {
            r2d.velocity = new Vector2(r2d.velocity.x, r2d.velocity.y * 0.5f);
        }

        Rotate();
    }

    private void FixedUpdate()
    {
        r2d.velocity = new Vector2(Horizontal * Speed, r2d.velocity.y);
    }

    private void Rotate()
    {
        if (FacingRight && Horizontal < 0f || !FacingRight && Horizontal > 0f)
        {
            FacingRight = !FacingRight;
            Vector3 localscale = transform.localScale;
            localscale.x *= -1f;
            transform.localScale = localscale;
        }
    }

    private bool Grounded()
    {
        return Physics2D.OverlapCircle(groundcheck.position, 0.2f, Groundlayer);
    }
}
