using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;


namespace TowerDefese
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject _skeletonPrefab;
        [SerializeField] private Transform _startTransform;
        [SerializeField] private GameObject _infoPanel;

        public void SpawnEnemy()
        {
            var enemyGO = Instantiate(_skeletonPrefab, _startTransform.position, Quaternion.identity);
            var enemy = enemyGO.GetComponent<Skeleton>();
            CreateInfoUI(enemy);

        }

        private void CreateInfoUI(Skeleton enemy)
        {
            var canvas = GameObject.Find("Canvas");
            var nameGO = Instantiate(_infoPanel, canvas.transform);
            var name = nameGO.transform.Find("Name").GetComponentInChildren<Text>();

            name.text = enemy.Model.Name;

            var positionConstraint = nameGO.GetComponent<PositionConstraint>();
            positionConstraint.AddSource(new ConstraintSource());

            var soursetransform = positionConstraint.GetSource(0);
            soursetransform.sourceTransform = enemy.transform;
            soursetransform.weight = 1.0f;
            positionConstraint.SetSource(0, soursetransform);
            positionConstraint.constraintActive = true;
        }
    }
}