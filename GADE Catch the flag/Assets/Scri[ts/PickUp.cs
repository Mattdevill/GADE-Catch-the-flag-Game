using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool checkFlag;
    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && checkFlag)
        {
            checkFlag = false;

            this.transform.SetParent(null);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E) && !checkFlag)
            {
                this.transform.parent = other.transform;

                checkFlag = true;
                //Debug.Log("test");
            }

            
        }
    }

}
 