using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public int playerScore = 0;

    public TextMeshProUGUI enemyScoreText;
    public int enemyScore = 0;

    //public static int blueScore = 0;
    //public static int redScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerScoreText.text = "Player:" + playerScore;
        enemyScoreText.text = "Enemy:" + enemyScore;
    }

    // Update is called once per frame
    void Update()
    {
        playerScoreText.text = "Player:" + playerScore.ToString();
        enemyScoreText.text = "Enemy:" + enemyScore.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlueFlag") && this.CompareTag("BlueBase"))
        {
            playerScore++;
           playerScoreText.text = "Player:" + playerScore;

        }
        //Debug.Log("Point Test");

        if (other.CompareTag("RedFlag") && this.CompareTag("RedBase"))
        {
            enemyScore++;
            enemyScoreText.text = "Enemy:" + enemyScore;
        }
    }

}
