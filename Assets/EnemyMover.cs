using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMover : MonoBehaviour
{
    public GameObject TargetObj;


    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = TargetObj.transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
