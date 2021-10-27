using System;
using UnityEngine;


namespace TowerDefese
{
    [CreateAssetMenu(fileName ="Data", menuName = "ScriptableObjects/ActiveEnemySO", order = 1)]
    public class ActiveEnemySO: ScriptableObject
    {
        public Enemy Enemy;

        public void SetActiveEnemy(string name)
        {
            Enemy = (Enemy)Enum.Parse(typeof(Enemy), name);
        }
    }
}