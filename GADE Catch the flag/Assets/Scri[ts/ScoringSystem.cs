using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public int playerScore;

    //public static int blueScore = 0;
    //public static int redScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        //playerScoreText.text = "Player:" + playerScore;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlueFlag"))
        {
            
            playerScore ++;
        }
        Debug.Log("Point Test");
    }

}
