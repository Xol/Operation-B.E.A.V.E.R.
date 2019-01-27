using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    private const int ENEMY_MOVING_LENGTH_VALUE = 30;
    public int enemyMovementLength = ENEMY_MOVING_LENGTH_VALUE;
    public float speed = 50f;
    public float movingDirection = 1;

    void FixedUpdate()
    {
        handleMovement(movingDirection);

        enemyMovementLength -= 1;

            if (enemyMovementLength == 0)
            {
                movingDirection *= -1;
                enemyMovementLength = ENEMY_MOVING_LENGTH_VALUE;
            }
    }

    private void handleMovement(float horizontal)
    {
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);
    }

    public void setMovingDirection(int direction)
    {
        this.movingDirection = direction;
    }
}
