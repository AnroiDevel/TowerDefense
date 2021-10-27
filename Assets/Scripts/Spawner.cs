using UnityEngine;


namespace TowerDefese
{
    public class Spawner : MonoBehaviour
    {
        private GameObject _enemyPrefab;
        [SerializeField] private Transform _startTransform;
        [SerializeField] private EnemyUI _enemyUI;

        public void SpawnEnemy()
        {
            if (_enemyPrefab == null) return;
            var enemyGO = Instantiate(_enemyPrefab, _startTransform.position, Quaternion.identity);
            var enemy = enemyGO.GetComponent<IEnemy>();
           _enemyUI.CreateInfoUI(enemy);

        }


        internal void SetEnemyPrefab(GameObject enemyPrefab)
        {
            _enemyPrefab = enemyPrefab;
        }
    }

}