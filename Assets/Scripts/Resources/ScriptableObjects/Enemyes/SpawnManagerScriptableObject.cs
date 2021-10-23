using UnityEngine;


namespace TowerDefese
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
    public class SpawnManagerScriptableObject : ScriptableObject
    {
        public string Name;
        public float Speed;
        public Armor Armor;
    }
}