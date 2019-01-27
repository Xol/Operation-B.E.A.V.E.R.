using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speed = 50f;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);
    }

    private void HandleMovement(float horizontal)
    {
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);
    }
}
