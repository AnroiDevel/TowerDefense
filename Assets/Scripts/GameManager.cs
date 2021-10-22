using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TowerDefese;
using UnityEngine.Animations;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _skeletonPrefab;
    [SerializeField] private Transform _startTransform;
    [SerializeField] private Transform _canvasTransform;
    [SerializeField] private GameObject _objectInfoPanel;
    [SerializeField] private SpawnManagerScriptableObject _spawnManagerScriptableObject;

    public void CreateEnemy()
    {
        var enemyGO = Instantiate(_skeletonPrefab,_startTransform.position, Quaternion.identity);
        var enemy = enemyGO.GetComponent<Skeleton>();
        var nameGO = Instantiate(_objectInfoPanel, _canvasTransform);
        var name = nameGO.GetComponentInChildren<Text>();

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
