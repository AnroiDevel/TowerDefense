using UnityEngine;


namespace TowerDefese
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EnemySO", order = 1)]
    public class EnemySO : ScriptableObject
    {
        public string Name;
        public float Speed;
        public float Health;
        public Armor Armor;
    }
}