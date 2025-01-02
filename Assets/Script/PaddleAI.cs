using UnityEngine;
using UnityEngine.EventSystems;

public class PaddleAI : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public Rigidbody2D ballRigidBody;
    public float movementSpeed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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


    float findBallYPosition()
    {
        return ballRigidBody.position.y;
    }
}
