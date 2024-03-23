using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
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

    /*public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "playerCollision")
        {
            redFlag.transform.parent = null;
            //hasRedFlag = false;

            blueFlag.transform.parent = null;
            Debug.Log("Test flag drop");
        }
    }*/
}
