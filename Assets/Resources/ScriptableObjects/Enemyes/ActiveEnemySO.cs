using System;
using UnityEngine;


namespace TowerDefese
{
    [CreateAssetMenu(fileName ="Data", menuName = "ScriptableObjects/ActiveEnemySO", order = 1)]
    public class ActiveEnemySO: ScriptableObject
    {
        public Enemies Enemy;

        public void SetActiveEnemy(string name)
        {
            Enemy = (Enemies)Enum.Parse(typeof(Enemies), name);
        }
    }
}