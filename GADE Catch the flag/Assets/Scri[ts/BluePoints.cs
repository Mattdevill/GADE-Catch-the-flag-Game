using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePoints : MonoBehaviour
{
    public ScoringSystem ScoringSystem;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlueFlag") && this.CompareTag("BlueBase"))
        {
            ScoringSystem.roundChange = true;
            ScoringSystem.playerScore++;
            ScoringSystem.playerScoreText.text = "Player:" + ScoringSystem.playerScore;
            Debug.Log("Score test");

        }
        //Debug.Log("Point Test");

        
    }
}
