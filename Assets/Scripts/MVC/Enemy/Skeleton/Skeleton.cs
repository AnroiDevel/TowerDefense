using UnityEngine;
using System;


namespace TowerDefese
{
    public class Skeleton : EnemyView<SkeletonModel, EnemyController<SkeletonModel>>, IEnemy
    {
        [SerializeField] private EnemySO _sceletonSO;
        public Action DamageEvent;

        public string Name => Model.Name;

        public override void Awake()
        {
            base.Awake();
            Model.Health = _sceletonSO.Health;
            Model.Name = _sceletonSO.Name;
            Model.Armor = _sceletonSO.Armor;
            Model.Speed = _sceletonSO.Speed;

        }

        public void GetDamage(float damage)
        {
            Model.Health -= damage;
            DamageEvent?.Invoke();
            Debug.Log($"Я {name} получил урон {damage} единиц, у меня осталось {Model.Health} здоровья");
        }
    }
}