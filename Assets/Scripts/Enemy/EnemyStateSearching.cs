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
            
            Vector3 dir = player.transform.TransformVector(Vector3.forward) * 100;


            Debug.DrawRay(player.transform.position, dir);


            //if (Physics.Raycast(source, dir, Mathf.Infinity))
            //    print("hit");
        }
        else
        {
            tt -= Time.deltaTime;
        }
    }
}
