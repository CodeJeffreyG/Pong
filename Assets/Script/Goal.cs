using UnityEngine;

public class Goal : MonoBehaviour
{
    public float score = 0; // Tracks the score for this goal


    void Start()
    {
        score = 0;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.CompareTag("Ball"))
        {
            score += 1;
            Debug.Log("Goal scored! Current score: " + score);
        }
    }
}
