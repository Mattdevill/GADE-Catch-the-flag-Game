using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    Vector3 velocity;

    public float gravity = -9.81f;

    public bool checkFlag;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Q) && checkFlag)
        {
            checkFlag = false;

            this.transform.SetParent(null);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "BlueFlag")
        {
            if (Input.GetKeyDown(KeyCode.E) && !checkFlag)
            {
                other.transform.SetParent(this.transform);

                //this.transform.parent = other.transform;

                checkFlag = true;
                //Debug.Log("test");
            }


        }
    }
}
