using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRedFlag : MonoBehaviour
{
    //public StateManager StateManagerScript;
     

    public Transform redFlag;

    // Start is called before the first frame update
    /*private void Start()
    {
        StateManagerScript = GameObject.FindObjectOfType<StateManager>();
    }*/

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
