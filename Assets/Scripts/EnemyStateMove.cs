using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

using EnemyStates;

public class EnemyStateMove : EnemyState
{
    public GameObject TargetObj;
    private NavMeshAgent agent;
    private float tt = 0f;
    private float updateFreq = 1.0f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public override void StateUpdate()
    {
        if (tt <= 0)
        {
            agent.destination = TargetObj.transform.position;
            tt = updateFreq;
        }
        else
        {
            tt -= Time.deltaTime;
        }
    }
}
