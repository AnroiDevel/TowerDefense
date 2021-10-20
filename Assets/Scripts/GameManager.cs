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

    [SerializeField] private GameObject _nameUIPrefab;
    private Text _name;
    private ParentConstraint _parentConstraint;
    private Skeleton _enemy;

    public void CreateEnemy()
    {
        var enemyGO = Instantiate(_skeletonPrefab);
        enemyGO.transform.position = _startTransform.position;
        _enemy = enemyGO.GetComponent<Skeleton>();

        var nameGO = Instantiate(_nameUIPrefab);

        _name = nameGO.GetComponent<Text>();
        _parentConstraint = nameGO.GetComponent<ParentConstraint>();

        _name.text = _enemy.name;

        _parentConstraint.AddSource(new ConstraintSource());
        var soursetransform = _parentConstraint.GetSource(0);
        soursetransform.sourceTransform = _enemy.transform;

        _parentConstraint.translationAtRest = Vector3.zero;
        _parentConstraint.constraintActive = true;

    }

}
