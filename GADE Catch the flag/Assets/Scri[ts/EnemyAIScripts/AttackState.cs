using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State
{
    public FetchPlayerFlagState fetchPlayerFlagState;
    //public StateManager StateManagerScript;

    public bool isFlagInRange;

    /*private void Start()
    {
        StateManagerScript = GameObject.FindObjectOfType<StateManager>();
    }*/

    public override State RunCurrentState()
    {
        if(isFlagInRange)
        {
            return fetchPlayerFlagState;
        }

        else
        {
            return this;
        }
        //Debug.Log("Attack successfull");
        
    }
}
