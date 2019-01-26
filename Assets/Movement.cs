using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speed = 50f;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);


        //if (Input.GetKey("d"))
        //{
        //    rb2d.AddForce(new Vector2(forwardForce * Time.deltaTime, 0f));
        //}

        //if (Input.GetKey("a"))
        //{
        //    rb2d.AddForce(new Vector2(-forwardForce * Time.deltaTime, 0f));
        //}

        //rb2d.AddForce(Vector2.zero);
    }

    private void HandleMovement(float horizontal)
    {
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);
    }
}
