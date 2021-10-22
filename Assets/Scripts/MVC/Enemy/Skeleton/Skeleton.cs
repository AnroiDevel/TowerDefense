using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    public class Skeleton : EnemyView<SkeletonModel,EnemyController<SkeletonModel>>
    {
        [SerializeField] private SpawnManagerScriptableObject _sceletonSO;

        private void Start()
        {
            Model.Name = _sceletonSO.Name;
            Model.Armor = _sceletonSO.Armor;
            Model.Speed = _sceletonSO.Speed;
        }
    }
}