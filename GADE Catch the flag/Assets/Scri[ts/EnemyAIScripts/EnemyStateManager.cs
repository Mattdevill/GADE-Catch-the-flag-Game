using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStateManager : MonoBehaviour
{
    //For FetchRedFlag State
    public NavMeshAgent agent;
    public GameObject redFlag;
    public GameObject blueFlag;

    //For Chase State
    public bool isInAttackRange = false;
    public bool canSeePlayer = false;
    public GameObject player;
    public float radius;
    [Range(0, 360)]
    public float angle;
    public LayerMask targetMask;
    public LayerMask obctructionMask;

    //For ReturnToBase State
    public GameObject redBase;
    public bool hasRedFlag = false;

    // Define your player states here
    public enum EnemyState
    {
        FetchRedFlag,
        ReturnToBase,
        Chase,

        // Add more states as needed
    }

    // Current state of the player
    private EnemyState currentState;

    void Start()
    {
        // Set the initial state when the script starts
        SetState(EnemyState.FetchRedFlag);
    }

    void Update()
    {   
        //Runs the FieldOfView method that allows the enemy to see the player
        FieldOfView();

        // Handle input or other conditions to determine state transitions
        if (hasRedFlag == true)
        {
            SetState(EnemyState.ReturnToBase);
        }
        else if (canSeePlayer == true && hasRedFlag == false)
        {
            SetState(EnemyState.Chase);
        }
        
        else
        {
            SetState(EnemyState.FetchRedFlag);
        }

        // Perform state-specific behavior
        PerformStateBehavior();
    }

    // The method used to set the current state
    private void SetState(EnemyState newState)
    {
        currentState = newState;
        // Perform any additional actions when entering a new state
        EnterState();
    }

    // The method to handle state-specific behavior
    private void PerformStateBehavior()
    {
        // Implement behavior specific to each state
        switch (currentState)
        {
            case EnemyState.FetchRedFlag:
                // Code for FetchRedFag state

                agent.SetDestination(redFlag.transform.position);
                hasRedFlag = false;
               
                break;

            case EnemyState.ReturnToBase:
                // Code for jumping state

                agent.SetDestination(redBase.transform.position);

                break;

            case EnemyState.Chase:
                // Code for chase state

                agent.SetDestination(player.transform.position);

                break;
        }
    }

    // Method to handle actions when entering a new state
    private void EnterState()
    {
        // Implement any actions needed when entering a new state
        //Debug.Log("Entering State: " + currentState);
    }

    //Method to handle enemy view
    public void FieldOfView()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, targetMask);

        if (rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;

            if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);

                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obctructionMask))
                {
                    canSeePlayer = true;
                }
                else
                {
                    canSeePlayer = false;
                }
            }
            else
            {
                canSeePlayer = false;
            }
        }
        else if (canSeePlayer)
        {
            canSeePlayer = false;
        }
    }

    // the code to get the enemy to pickup the red flag
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RedFlag")
        {
            other.transform.SetParent(this.transform);
            hasRedFlag = true;
        }
        else
        {
            hasRedFlag = false;
        }
    }
}
