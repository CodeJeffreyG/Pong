using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rigidBody;
    public float startingSpeed;
    private bool ballStart = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!ballStart && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)))
        {
            ballStart = true;
            shootBall();
        }

    }

    void shootBall()
    {
        bool isRight = Random.value >= 0.5f;
        float xVelocity = -1f;
        float yVelocity = Random.Range(-1f, 1f);
        if (isRight == true)
        {
            xVelocity = 1f;
        }

        rigidBody.linearVelocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed);
        print(rigidBody.linearVelocity);
    }
}


