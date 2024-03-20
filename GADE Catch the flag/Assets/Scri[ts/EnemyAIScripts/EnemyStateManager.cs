using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStateManager : MonoBehaviour
{
    //For FetchRedFlag State
    public NavMeshAgent agent;
    public Transform redFlag;

    // Define your player states here
    public enum EnemyState
    {
        FetchRedFlag,
        ReturnToBase,
        Chase,
        Attack,
        FetchBlueFlag

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
        // Handle input or other conditions to determine state transitions
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetState(EnemyState.ReturnToBase);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            SetState(EnemyState.Attack);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            SetState(EnemyState.Chase);
        }
        else if (Input.GetKey(KeyCode.V))
        {
            SetState(EnemyState.FetchBlueFlag);
        }
        else
        {
            SetState(EnemyState.FetchRedFlag);
        }

        // Perform state-specific behavior
        PerformStateBehavior();
    }

    // Method to set the current state
    private void SetState(EnemyState newState)
    {
        currentState = newState;
        // Perform any additional actions when entering a new state
        EnterState();
    }

    // Method to handle state-specific behavior
    private void PerformStateBehavior()
    {
        // Implement behavior specific to each state
        switch (currentState)
        {
            case EnemyState.FetchRedFlag:
                // Code for idle state
                agent.SetDestination(redFlag.position);

                break;
            case EnemyState.Chase:
                // Code for walking state
                break;
            case EnemyState.ReturnToBase:
                // Code for jumping state
                break;
            case EnemyState.Attack:
                // Code for attacking state
                break;
            case EnemyState.FetchBlueFlag:
                // Code for fetching blue flag state
                break;
                // Add more cases for additional states
        }
    }

    // Method to handle actions when entering a new state
    private void EnterState()
    {
        // Implement any actions needed when entering a new state
        Debug.Log("Entering State: " + currentState);
    }
}
