using UnityEngine;
using System;


namespace TowerDefese
{
    public class Enemy : BaseView<EnemyModel, EnemyController>, IEnemy
    {
        [SerializeField] private EnemySO _enemySO;
        public string Name => Model.Name;

        public Armor Armor => Model.Armor;

        public float Health => Model.Health;

        public float Speed => Model.Speed;

        public event Action<float> GetDamageEvent;

        public override void Awake()
        {
            base.Awake();
            Model.MaxHealth = _enemySO.MaxHealth;
            Model.Health = _enemySO.MaxHealth;
            Model.Name = _enemySO.Name;
            Model.Armor = _enemySO.Armor;
            Model.Speed = _enemySO.Speed;
            Model.Price = _enemySO.Price;

        }

        private void Start()
        {

        }

        public void GetDamage(float damage)
        {
            Model.Health -= damage;
            GetDamageEvent?.Invoke(100 / (Model.MaxHealth / Model.Health));//процент от максимума
            Debug.Log($"Я {name} получил урон {damage} единиц, у меня осталось {Model.Health} здоровья");

            if (Model.Health <= 0)
            {
                gameObject.SetActive(false);
                PlayerUI.Data.Gold = Model.Price;
                return;
            }

        }
    }
}