using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private float leftScore = 0;
    private float rightScore = 0;


    public void calculateScore(String tag)
    {
        if (tag == "RightGoal")
        {
            Debug.Log("Right goal entered, left score: " + getLeftScore());
            leftScore += 1;
        }
        else if (tag == "LeftGoal")
        {
            Debug.Log("Left goal entered, right score: " + getRightScore());
            rightScore += 1;
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
