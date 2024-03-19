using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public State currentState;
    /*public bool IsInAttackRange;
    public bool isFlagInRange;

    public bool hasFlag;*/

    public bool canSeePlayer;

    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        State nextState = currentState?.RunCurrentState();

        if (nextState != null )
        {
            SwitchToNextState(nextState);
        }
       
    }

    private void SwitchToNextState(State nextState)
    {
        currentState = nextState;
    }
}
