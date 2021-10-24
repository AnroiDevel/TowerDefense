using UnityEngine;


namespace TowerDefese
{
    [CreateAssetMenu(fileName ="Data", menuName = "ScriptableObjects/ActiveEnemySO", order = 1)]
    public class ActiveEnemySO: ScriptableObject
    {
        public Enemy Enemy;
    }
}