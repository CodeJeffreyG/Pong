using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rigidBody;
    public float startingSpeed;
    void Start()
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

    // Update is called once per frame
    void Update()
    {

    }
}
