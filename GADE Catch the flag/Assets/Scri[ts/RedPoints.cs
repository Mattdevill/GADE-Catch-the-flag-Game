using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPoints : MonoBehaviour
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
        if (other.CompareTag("RedFlag") && this.CompareTag("RedBase"))
        {
            ScoringSystem.roundChange = true;
            ScoringSystem.enemyScore++;
            ScoringSystem.enemyScoreText.text = "Enemy:" + ScoringSystem.enemyScore;
        }
    }

}
