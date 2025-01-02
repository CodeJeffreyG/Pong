using UnityEngine;

public class Ball : MonoBehaviour
{
    public SpriteRenderer sprite;

    public Transform transformLeftPaddle;
    public Transform transformRightPaddle;
    public Rigidbody2D rigidBody;
    public float startingSpeed;
    public float incrementSpeed = 1.1f;
    private bool ballStart = false;

    void Start()
    {
        rigidBody.linearVelocity = Vector2.zero;
        rigidBody.position = Vector2.zero;
    }

    void Update()
    {
        // Check for user input to start the ball
        if (!ballStart && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)))
        {
            ballStart = true;
            shootBall();
        }
    }

    void shootBall()
    {

        bool isRight = Random.value >= 0.5f;
        float xVelocity = isRight ? 1f : -1f;
        float yVelocity = Random.Range(-1f, 1f);


        Vector2 direction = new Vector2(xVelocity, yVelocity).normalized;


        rigidBody.linearVelocity = direction * startingSpeed;

        ;
    }

    void resetPosition()
    {
        ballStart = false;
        rigidBody.linearVelocity = Vector2.zero;
        rigidBody.position = Vector2.zero;
        transformLeftPaddle.position = new Vector2(transformLeftPaddle.position.x, 0);
        transformRightPaddle.position = new Vector2(transformRightPaddle.position.x, 0);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody != null)
        {
            if (collision.gameObject.CompareTag("PaddleRight"))
            {
                increaseSpeed();
                Debug.Log("Hit the right paddle!");
                sprite.color = Color.red;
            }
            else if (collision.gameObject.CompareTag("PaddleLeft"))
            {
                increaseSpeed();
                Debug.Log("Hit the left paddle!");
                sprite.color = Color.blue;
            }
        }
    }

    void increaseSpeed()
    {
        rigidBody.linearVelocity *= incrementSpeed;
    }
}







