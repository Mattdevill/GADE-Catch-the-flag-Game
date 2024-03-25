using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlueFlag : MonoBehaviour
{
    //Script to move the blueFlag back to start when the enemy collides with it.

    public Transform blueFlag;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            blueFlag.transform.position = new Vector3(-0.021f, -0.08f, 63.965f);
        }
    }
}
