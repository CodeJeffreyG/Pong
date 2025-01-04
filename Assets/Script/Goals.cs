using System;
using UnityEngine;

public class Goals : MonoBehaviour
{
    ScoreManager scoreManager;

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        String currentTag = collision.gameObject.tag;

        scoreManager.calculateScore(currentTag);
    }
}
