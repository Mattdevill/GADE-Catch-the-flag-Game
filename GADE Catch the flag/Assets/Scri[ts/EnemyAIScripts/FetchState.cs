using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FetchState : State
{
    public ChaseState chaseState;

    public bool canSeePlayer;

    public ReturnToBaseState returnToBaseState;

    public bool hasFlag;

    public override State RunCurrentState()
    {
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
            return this;
        }
    }
}
