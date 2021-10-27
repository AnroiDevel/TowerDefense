using UnityEngine;
using System;


namespace TowerDefese
{
    public class Skeleton : EnemyView<SkeletonModel, EnemyController<SkeletonModel>>, IEnemy
    {
        [SerializeField] private EnemySO _sceletonSO;
        public string Name => Model.Name;

        public event Action<float> GetDamageEvent;

        public override void Awake()
        {
            base.Awake();
            Model.MaxHealth = _sceletonSO.MaxHealth;
            Model.Health = _sceletonSO.MaxHealth;
            Model.Name = _sceletonSO.Name;
            Model.Armor = _sceletonSO.Armor;
            Model.Speed = _sceletonSO.Speed;

        }

        public void GetDamage(float damage)
        {
            Model.Health -= damage;
            GetDamageEvent?.Invoke(100/(Model.MaxHealth/Model.Health));//процент от максимума
            Debug.Log($"Я {name} получил урон {damage} единиц, у меня осталось {Model.Health} здоровья");

            if(Model.Health <= 0)
            {
                gameObject.SetActive(false);
                return;
            }

        }
    }
}