using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject redFlag;
    public GameObject blueFlag;

    public GameObject enemy;
    public GameObject player;

     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            redFlag.transform.parent = null;
            //hasRedFlag = false;

            blueFlag.transform.parent = null;

            enemy.GetComponent<EnemyStateManager>().hasRedFlag = false;
            player.GetComponent<PlayerMovement>().checkFlag = false;


            Debug.Log("Test flag drop");
        }
    }
}
