using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    public class Skeleton : EnemyView<SkeletonModel,EnemyController<SkeletonModel>>
    {
        private void Start()
        {
            Debug.Log(Model.Speed);
        }
    }
}