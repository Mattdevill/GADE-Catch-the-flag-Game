using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRedFlag : MonoBehaviour
{
    //Script to move the redFlag back to start when the player presses E will in range of it.

    public Transform redFlag;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //this.transform.parent = other.transform;

                redFlag.transform.position = new Vector3(-0.55f, -0.08f, -64.36f); 
            }
        }
    }
}
