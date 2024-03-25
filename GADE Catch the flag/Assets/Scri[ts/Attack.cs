using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //Script to make the enemy and player drop their flags if they collide.

    public GameObject redFlag;
    public GameObject blueFlag;

    public GameObject enemy;
    public GameObject player;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            redFlag.transform.parent = null;

            blueFlag.transform.parent = null;

            enemy.GetComponent<EnemyStateManager>().hasRedFlag = false;
            player.GetComponent<PlayerMovement>().checkFlag = false;
        }
    }
}
