using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePoints : MonoBehaviour
{
    //Script to give the player points when the blueFlag collides with the blueBase.

    public ScoringSystem ScoringSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlueFlag") && this.CompareTag("BlueBase"))
        {
            ScoringSystem.roundChange = true;
            ScoringSystem.playerScore++;
            ScoringSystem.playerScoreText.text = "Player:" + ScoringSystem.playerScore;
            Debug.Log("Score test");

        }
    }
}
