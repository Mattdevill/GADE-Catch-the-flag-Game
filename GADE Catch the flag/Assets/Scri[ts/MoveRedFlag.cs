using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRedFlag : MonoBehaviour
{
    public Transform redFlag;

    // Start is called before the first frame update
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
                redFlag.transform.position = new Vector3(1f, 1f, 1f); 
            }
        }
    }
}
