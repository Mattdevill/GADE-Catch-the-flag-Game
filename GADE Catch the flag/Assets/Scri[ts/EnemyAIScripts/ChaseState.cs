using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State
{
    public AttackState attackState;

    public bool IsInAttackRange;

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
            /*self.transform.position = Vector3.MoveTowards(self.transform.position, targetObject.position, 10 * Time.deltaTime);

            Debug.Log("Test");*/

            return this;

           
        }
    }

    private void Update()
    {

    }
}
