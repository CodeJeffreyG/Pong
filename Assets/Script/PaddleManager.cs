using UnityEngine;

public class PaddleManager : MonoBehaviour
{
    bool leftPlayerPaddleMoving = true;


    [SerializeField] PaddleMovement leftPaddle;
    [SerializeField] PaddleMovement rightPaddle;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.D))
        {
            rightPaddle.GetComponent<AIController>().enabled = true;
            leftPaddle.GetComponent<AIController>().enabled = false;
            leftPlayerPaddleMoving = true;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            rightPaddle.GetComponent<AIController>().enabled = false;
            leftPaddle.GetComponent<AIController>().enabled = true;
            leftPlayerPaddleMoving = false;
        }
    }
}
