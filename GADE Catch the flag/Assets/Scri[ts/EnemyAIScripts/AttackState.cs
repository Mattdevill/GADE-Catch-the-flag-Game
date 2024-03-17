using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State
{
    public FetchPlayerFlagState fetchPlayerFlagState;

    public bool isFlagInRange;


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
