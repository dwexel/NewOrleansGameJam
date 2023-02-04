using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using EnemyStates;


public class EnemyStateHandler : MonoBehaviour
{
    public GameObject player;

    private EnemyState state;

    private void Switch(EnemyState s)
    {

    }

    void Start()
    {
        state = GetComponent<EnemyStateMove>();
        state.StateInit(player);


        EnemyState[] states = GetComponents<EnemyState>();
        foreach (EnemyState s in states)
            print(s);

    }

    void Update()
    {
        state.StateUpdate();


        //print("here");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Switch(GetComponent<EnemyStateWander>());


            state = GetComponent<EnemyStateWander>();
            state.StateInit(player);
            state.StateEnter();
        }
    }
}

namespace EnemyStates
{
    abstract public class EnemyState : MonoBehaviour
    {
        public bool initialized;


        virtual public void StateUpdate()
        {
        }

        virtual public void StateInit(GameObject player)
        {
        }

        virtual public void StateEnter()
        {
        }

        virtual public void StateExit()
        { 
        }
    }
}