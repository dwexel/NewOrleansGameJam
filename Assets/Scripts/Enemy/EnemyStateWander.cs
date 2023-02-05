using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

using EnemyStates;

public class EnemyStateWander : EnemyState
{
    private GameObject player;
    private NavMeshAgent agent;

    // change speed
    public override void StateInit(GameObject p)
    {
        player = p;
        agent = GetComponent<NavMeshAgent>();

        Vector3 pl = player.transform.position;
        randDest(pl);
    }
    private void randDest(Vector3 target)
    {
        float dev = 10f;

        float randX = Random.Range(target.x - dev, target.x + dev);
        float randZ = Random.Range(target.z - dev, target.z + dev);

        agent.destination = new Vector3(randX, target.y, randZ);
    }

    public override void StateUpdate()
    {
        if (agent.remainingDistance < 2.0)
        {
            print("new target");
            randDest(player.transform.position);
        }
    }
}
