using UnityEngine;


namespace TowerDefese
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject _enemyPrefab;
        [SerializeField] public SpawnManagerScriptableObject _spawnManagerValues;

        private void Start()
        {
            SpawnEntities();
        }

        private void SpawnEntities()
        {
            GameObject currentEntity = Instantiate(_enemyPrefab);
            currentEntity.name = _spawnManagerValues.Name;
        }
    }
}