using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    public class EnemyView<M,C> : BaseView<M, C>
        where M : EnemyModel
        where C : EnemyController<M>,new()
    {

    }
}