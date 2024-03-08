using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject blueFlagOnPlayer;

    // Start is called before the first frame update
    void Start()
    {
        blueFlagOnPlayer.SetActive(false);
    }   

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                blueFlagOnPlayer.SetActive(true);
            }
        }
    }
}
