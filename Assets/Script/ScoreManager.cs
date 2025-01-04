using UnityEngine;
using System;

public class ScoreManager : MonoBehaviour
{
    private float leftScore = 0;
    private float rightScore = 0;


    public void calculateScore(String tag)
    {
        if (tag == "LeftGoal")
        {
            rightScore++;
            Debug.Log("Right player scored! Right score: " + rightScore);
        }
        else if (tag == "RightGoal")
        {
            leftScore++;
            Debug.Log("Left player scored! Left score: " + leftScore);
        }


    }

    float getLeftScore()
    {
        return leftScore;
    }

    float getRightScore()
    {
        return rightScore;
    }

}
