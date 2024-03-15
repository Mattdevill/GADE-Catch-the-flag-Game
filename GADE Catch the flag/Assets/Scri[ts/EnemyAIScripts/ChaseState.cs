using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChaseState : State
{
    public AttackState attackState;

    public bool IsInAttackRange;

    public NavMeshAgent agent;

    public Transform player;

   // public Transform targetObject;

    //public GameObject self;

    public override State RunCurrentState()
    {
        if (IsInAttackRange)
        {
            return attackState;
        }
        else
        {
            agent.SetDestination(player.position);

            /*self.transform.position = Vector3.MoveTowards(self.transform.position, targetObject.position, 10 * Time.deltaTime);

            Debug.Log("Test");*/

            return this;

           
        }
    }

    private void Update()
    {

    }
}
