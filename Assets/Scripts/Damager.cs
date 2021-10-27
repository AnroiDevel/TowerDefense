using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    public class Damager : MonoBehaviour
    {
        [SerializeField] private float _damage = 10;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<IEnemy>(out var enemy))
            {
                enemy.GetDamage(_damage);
                gameObject.SetActive(false);
            }

        }
    }
}