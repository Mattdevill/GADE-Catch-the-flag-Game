using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public State currentState;


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
            //Debug.Log(nextState);
        }
       
    }

    private void SwitchToNextState(State nextState)
    {
        currentState = nextState;
    }
}
