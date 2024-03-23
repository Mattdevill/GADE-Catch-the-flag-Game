using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRound : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    public GameObject redBase;
    public GameObject blueBase;

    public GameObject redFlag;
    public GameObject blueFlag;
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
        // for blueFlag
        if (other.gameObject.tag == "BlueBase")
        {
            //blueFlag reset
            blueFlag.transform.position = new Vector3(-0.021f, -0.08f, 63.965f);
            blueFlag.transform.parent = null;

            //redFlag reset
            //redFlag.transform.position = new Vector3(-0.55f, -0.08f, -64.36f);
            //redFlag.transform.parent = null;

            //enemy reset
            enemy.transform.position = new Vector3(0f , 1.07f, 52.5f);

            //player reset
            player.transform.position = new Vector3(0f, 1.07f, -52.5f);
        }

        // for redFlag
        if (other.gameObject.tag == "RedBase")
        {
            //blueFlag reset
            //blueFlag.transform.position = new Vector3(-0.021f, -0.08f, 63.965f);
            //blueFlag.transform.parent = null;

            //redFlag reset
            redFlag.transform.position = new Vector3(-0.55f, -0.08f, -64.36f);
            redFlag.transform.parent = null;

            //enemy reset
            enemy.transform.position = new Vector3(0f, 1.07f, 52.5f);

            //player reset
            player.transform.position = new Vector3(0f, 1.07f, -52.5f);
        }
    }

}
