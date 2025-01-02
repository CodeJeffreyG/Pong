using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rigidBody;
    public float startingSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isRight = Random.value >= 0.5f;
        float xVelocity = -1;
        float yVelocity = Random.Range(-1, 1);
        if (isRight)
        {
            xVelocity = 1;
        }

        rigidBody.linearVelocity = new Vector2(xVelocity, yVelocity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
