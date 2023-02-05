using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using EnemyStates;


public class EnemyStateHandler : MonoBehaviour
{
    public GameObject player;
    private EnemyState state;

    void Start()
    {
        EnemyState s = GetComponent<EnemyStateMove>();
        Switch(s);

        EnemyState[] states = GetComponents<EnemyState>();
        foreach (EnemyState ss in states)
            print(ss);

    }

    void Update()
    {
        state.StateUpdate();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //EnemyState s = GetComponent<EnemyStateWander>();
            EnemyState s = GetComponent<EnemyStateSearching>();
            Switch(s);
        }
    }


    private void Switch(EnemyState s)
    {
        state = s;
        if (!state.initialized)
            state.StateInit(player);
            state.initialized = true;
        state.StateEnter();
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
            this.initialized = true;
        }

        virtual public void StateEnter()
        {
        }

        virtual public void StateExit()
        { 
        }
    }
}