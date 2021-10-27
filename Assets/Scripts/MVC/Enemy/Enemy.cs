using UnityEngine;
using System;


namespace TowerDefese
{
    public class Enemy : EnemyView<EnemyModel, EnemyController<EnemyModel>>, IEnemy
    {
        [SerializeField] private EnemySO _enemySO;
        public string Name => Model.Name;

        public event Action<float> GetDamageEvent;

        public override void Awake()
        {
            base.Awake();
            Model.MaxHealth = _enemySO.MaxHealth;
            Model.Health = _enemySO.MaxHealth;
            Model.Name = _enemySO.Name;
            Model.Armor = _enemySO.Armor;
            Model.Speed = _enemySO.Speed;

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