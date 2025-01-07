using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField] PaddleMovement paddleMovement;
    [SerializeField] Rigidbody2D ballRigidBody;
    void Start()
    {

    }

    void Update()
    {
        RunAI();
    }




    float findBallYPosition()
    {
        return ballRigidBody.position.y;
    }

    void RunAI()
    {
        float currentPosition = transform.position.y;

        if (currentPosition > findBallYPosition())
        {
            paddleMovement.Move(false);
        }
        else if (currentPosition < findBallYPosition())
        {
            paddleMovement.Move(true);
        }

    }
}
