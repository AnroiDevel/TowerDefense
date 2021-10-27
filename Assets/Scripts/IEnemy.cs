using UnityEngine;

namespace TowerDefese
{
    internal interface IEnemy
    {
        void GetDamage(float damage);
        string Name { get; }
        Transform transform { get; }
    }
}