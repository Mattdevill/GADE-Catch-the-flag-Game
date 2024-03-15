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

    public override State RunCurrentState()
    {
        if (IsInAttackRange)
        {
            return attackState;
        }
        else
        {
            agent.SetDestination(player.position);

            return this;
        }
    }
}
