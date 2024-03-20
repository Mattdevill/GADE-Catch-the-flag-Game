using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/*public class FetchState : State
{
    //public StateManager StateManagerScript;

    public ChaseState chaseState;
    public bool canSeePlayer;

    public ReturnToBaseState returnToBaseState;
    public bool hasFlag;

    public NavMeshAgent agent;
    public Transform redFlag;

    /*private void Start()
    {
        StateManagerScript = GameObject.FindObjectOfType<StateManager>();
    }*/
    /*public override State RunCurrentState()
    {
        //agent.SetDestination(redFlag.position);
        //return this;
        if (canSeePlayer)
        {
            return chaseState; 
        }

        if (hasFlag)
        {
            return returnToBaseState;
        }

        else 
        {
            canSeePlayer = false;
            hasFlag = false;
            agent.SetDestination(redFlag.position);
            return this;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "RedFlag")
        {
            this.transform.parent = other.transform;
        }
    }
}*/
