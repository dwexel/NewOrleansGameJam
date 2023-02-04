using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMover : MonoBehaviour
{
    public GameObject TargetObj;
    private NavMeshAgent agent;
    private float tt = 0f;
    private float updateFreq = 1.0f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
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

        print(tt);
    }
}
