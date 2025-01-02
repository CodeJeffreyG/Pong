using UnityEngine;

public class Ball : MonoBehaviour
{

    public Transform transformLeftPaddle;
    public Transform transformRightPaddle;
    public Rigidbody2D rigidBody;
    public float startingSpeed;
    private bool ballStart = false;

    void Start()
    {
        // Ensure the ball starts stationary
        rigidBody.linearVelocity = Vector2.zero;
        rigidBody.position = Vector2.zero; // Start at the center of the screen
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

        Debug.Log("Ball velocity: " + rigidBody.linearVelocity);
    }

    void resetPosition()
    {
        ballStart = false;
        rigidBody.linearVelocity = Vector2.zero;
        rigidBody.position = Vector2.zero;
        transformLeftPaddle.position = new Vector2(transformLeftPaddle.position.x, 0);
        transformRightPaddle.position = new Vector2(transformRightPaddle.position.x, 0);

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Check if the ball entered a Goal trigger
        if (collider.CompareTag("Goal"))
        {
            Debug.Log("Goal scored!");
            resetPosition();
        }
    }
}
