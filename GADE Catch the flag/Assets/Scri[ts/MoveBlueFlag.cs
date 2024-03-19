using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlueFlag : MonoBehaviour
{
    //public StateManager StateManagerScript;


    public Transform blueFlag;

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
        if (other.gameObject.tag == "Enemy")
        {
            blueFlag.transform.position = new Vector3(-0.021f, -0.08f, 63.965f);
        }
    }
}
