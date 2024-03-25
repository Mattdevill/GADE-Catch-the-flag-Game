using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPoints : MonoBehaviour
{
    //Script to give the enemy points when the redFlag collides with the redBase.

    public ScoringSystem ScoringSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RedFlag") && this.CompareTag("RedBase"))
        {
            ScoringSystem.roundChange = true;
            ScoringSystem.enemyScore++;
            ScoringSystem.enemyScoreText.text = "Enemy:" + ScoringSystem.enemyScore;
        }
    }
}
