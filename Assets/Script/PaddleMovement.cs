using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleMovement : MonoBehaviour
{
    public float movementSpeed;

    public Transform transform;
    public Rigidbody2D rigidBody;
    public Rigidbody2D leftRigidBody;
    public Rigidbody2D rightRigidBody;
    public Rigidbody2D ballRigidBody;
    private bool isRightPaddle;
    private bool isRightAI = true;
    private bool isLeftAI;
    void Start()
    {
        isRightPaddle = transform.localPosition.x < 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (isRightPaddle)
        {
            if (Input.GetKey(KeyCode.W))
            {
                isRightAI = true;
                runAI(rightRigidBody);
                isLeftAI = false;

                transform.Translate(Vector2.up * Time.deltaTime * movementSpeed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * Time.deltaTime * movementSpeed);
            }




        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                isLeftAI = true;
                runAI(leftRigidBody);
                isRightAI = false;
                transform.Translate(Vector2.up * Time.deltaTime * movementSpeed);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.down * Time.deltaTime * movementSpeed);
            }

        }

        if (isLeftAI)
        {
            runAI(leftRigidBody);
        }

        if (isRightAI)
        {
            runAI(rightRigidBody);
        }



    }


    float findBallYPosition()
    {
        return ballRigidBody.position.y;
    }

    void runAI(Rigidbody2D rigidBody)
    {
        float currenetPosition = rigidBody.position.y;

        if (currenetPosition > findBallYPosition())
        {
            rigidBody.linearVelocity = new Vector2(0, -movementSpeed);
        }
        else if (currenetPosition < findBallYPosition())
        {
            rigidBody.linearVelocity = new Vector2(0, movementSpeed);
        }
        else if (currenetPosition == findBallYPosition())
        {
            return;
        }
    }
}

