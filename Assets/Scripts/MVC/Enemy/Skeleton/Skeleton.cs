using UnityEngine;


namespace TowerDefese
{
    public class Skeleton : EnemyView<SkeletonModel, EnemyController<SkeletonModel>>
    {
        [SerializeField] private SpawnManagerScriptableObject _sceletonSO;

        public override void Awake()
        {
            base.Awake();
            Model.Name = _sceletonSO.Name;
            Model.Armor = _sceletonSO.Armor;
            Model.Speed = _sceletonSO.Speed;

        }
    }
}