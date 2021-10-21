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
    private Text _name;
    private PositionConstraint _positionConstraint;
    private Skeleton _enemy;

    public void CreateEnemy()
    {
        var enemyGO = Instantiate(_skeletonPrefab);
        enemyGO.transform.position = _startTransform.position;
        _enemy = enemyGO.GetComponent<Skeleton>();

        var nameGO = Instantiate(_objectInfoPanel, _canvasTransform);

        _name = nameGO.GetComponentInChildren<Text>();
        _positionConstraint = nameGO.GetComponent<PositionConstraint>();

        _name.text = _enemy.Model.Name;

        _positionConstraint.AddSource(new ConstraintSource());
        var soursetransform = _positionConstraint.GetSource(0);
        soursetransform.sourceTransform = _enemy.transform;
        soursetransform.weight = 1.0f;
        _positionConstraint.SetSource(0, soursetransform);
        _positionConstraint.translationAtRest = Vector3.zero;
        _positionConstraint.constraintActive = true;

    }

}
