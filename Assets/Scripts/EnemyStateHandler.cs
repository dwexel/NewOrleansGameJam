using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// so you can use it
using EnemyStates;


public class EnemyStateHandler : MonoBehaviour
{
    public GameObject player;
    private EnemyState state;
    void Start()
    {
        state = GetComponent<EnemyStateMove>();
        state.StateStart(player);
    }

    void Update()
    {
        state.StateUpdate();
    }
}

// namespace
namespace EnemyStates
{
    abstract public class EnemyState : MonoBehaviour
    {
        public GameObject player;
        virtual public void StateUpdate()
        {
            print("base method activated");
        }

        virtual public void StateStart(GameObject player)
        {
            this.player = player;
        }
    }
}