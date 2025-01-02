using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleMovement : MonoBehaviour
{
    public float paddleSpeed;
    [SerializeField] Transform transform;
    private bool isRightPaddle;
    private bool isPressingUp;
    private bool isPressingDown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isRightPaddle = transform.localPosition.x > 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (isRightPaddle)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * Time.deltaTime * paddleSpeed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * Time.deltaTime * paddleSpeed);
            }



        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector2.up * Time.deltaTime * paddleSpeed);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.down * Time.deltaTime * paddleSpeed);
            }
        }
    }
}
