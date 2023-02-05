using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnemyStates;


public class EnemyStateSearching : EnemyState
{
    public GameObject RaycastSource;
    private GameObject player;

    private float tt = 0f;
    private float updateFreq = 0.3f;

    public override void StateInit(GameObject p)
    {
        player = p;
        print(p);
    }

    public override void StateUpdate()
    {
        if (tt <= 0)
        {
            tt = updateFreq;
            RaycastHit hit;

            Transform source = RaycastSource.transform;

            //Vector3 dir = player.transform.position - source;

            Vector3 dir = source.TransformDirection(Vector3.forward);

            if (Physics.Raycast(source.position, dir, out hit, 10))
                print("hitting");
            else
                print("not hitting");
        }
        else
        {
            tt -= Time.deltaTime;
        }
    }
}
