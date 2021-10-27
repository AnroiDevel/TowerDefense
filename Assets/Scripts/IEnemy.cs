using UnityEngine;
using System;

namespace TowerDefese
{
    public interface IEnemy
    {
        void GetDamage(float damage);
        string Name { get; }

        event Action<float> GetDamageEvent;
        Transform transform { get; }
    }
}