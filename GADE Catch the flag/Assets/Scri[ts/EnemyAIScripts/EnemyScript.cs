using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float maxSpeed;
    private float speed;

    private Collider[] hitColliders;
    private RaycastHit[] hit;

    public float sightRange;
    public float detectRange;

    public Rigidbody rb;
    public GameObject target;

    private bool seePlayer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!seePlayer)
        {
            hitColliders = Physics.OverlapSphere(transform.position, detectRange);
            foreach (var HitCollider in hitColliders)
            {
                if (HitCollider.tag == "Player")
                {
                    target = HitCollider.gameObject;
                    seePlayer = true;
                }
            }
        }
        else
        {
            /*if(Physics.Raycast(transform.position, (target.transform.position - transform.position), out hit, sightRange))
            {
                if(hit.collider.tag != "Player")
                {
                    seePlayer == false;
                }
            }*/
        }
    }
}
