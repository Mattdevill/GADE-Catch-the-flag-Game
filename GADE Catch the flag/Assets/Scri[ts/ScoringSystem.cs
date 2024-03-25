using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    public GameObject redBase;
    public GameObject blueBase;

    public GameObject redFlag;
    public GameObject blueFlag;

    public bool roundChange = false;

    public TextMeshProUGUI playerScoreText;
    public int playerScore = 0;

    public TextMeshProUGUI enemyScoreText;
    public int enemyScore = 0;

    public TextMeshProUGUI winnerText;

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

        playerScoreText.text = "Player:" + playerScore;
        enemyScoreText.text = "Enemy:" + enemyScore;


        if (playerScore == 5)
        {
            winnerText.text = "Blue Wins!";
        }

        if(enemyScore == 5)
        {
            winnerText.text = "Red Wins!";
        }

        if(roundChange == true)
        {
            enemy.GetComponent<EnemyStateManager>().hasRedFlag = false;
            player.GetComponent<PlayerMovement>().checkFlag = false;

            //blueFlag reset
            blueFlag.transform.position = new Vector3(-0.021f, -0.08f, 63.965f);
            blueFlag.transform.parent = null;

            enemy.GetComponent<EnemyStateManager>().hasRedFlag = false;
            player.GetComponent<PlayerMovement>().checkFlag = false;

            //blueFlag reset
            //blueFlag.transform.position = new Vector3(-0.021f, -0.08f, 63.965f);
            //blueFlag.transform.parent = null;

            //redFlag reset
            redFlag.transform.position = new Vector3(-0.55f, -0.08f, -64.36f);
            redFlag.transform.parent = null;

            roundChange = false;
        }

    }

    

}
