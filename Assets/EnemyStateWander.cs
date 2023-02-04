using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using EnemyStates;

public class EnemyStateWander : EnemyState
{
    public override void StateStart(GameObject player0)
    {
        base.StateStart(player);


    }

    public override void StateUpdate()
    {
        //base.StateUpdate();
        print(this.player);

    }
}
