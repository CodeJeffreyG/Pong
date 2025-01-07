using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleMovement : MonoBehaviour
{
    public float movementSpeed;

    public Transform transform;
    public Rigidbody2D rigidBody;

    private bool isRightPaddle;

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
                Move(true);

            }
            else if (Input.GetKey(KeyCode.S))
            {
                Move(false);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Move(true);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                Move(false);
            }

        }
    }


    public void Move(bool isUp)
    {
        Vector2 yDirection = isUp ? Vector2.up : Vector2.down;

        transform.Translate(yDirection * Time.deltaTime * movementSpeed);
    }



}





