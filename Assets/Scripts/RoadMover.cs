using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.U2D;


namespace TowerDefese
{
    public class RoadMover : MonoBehaviour
    {
        private SpriteShapeController _spriteShapeController;
        private List<Vector2> _points;
        private IEnemy _enemy;

        private void Start()
        {
            _spriteShapeController = FindObjectOfType<SpriteShapeController>();
            transform.parent = _spriteShapeController.transform;
            _enemy = GetComponent<IEnemy>();
            GetWayPoints();
        }

        private void GetWayPoints()
        {
            _points = new List<Vector2>();
            var way = _spriteShapeController.spline;
            var count = way.GetPointCount();
            for (int i = 0; i < count; i++)
            {
                _points.Add(way.GetPosition(i));
            }

            StartCoroutine(Walk());
        }

        private IEnumerator Walk()
        {
            var i = 0;
            while (i < _points.Count)
            {
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, _points[i], Time.deltaTime * _enemy.Speed);
                yield return new WaitForEndOfFrame();
                if ((Vector2)transform.localPosition == _points[i])
                    i++;

            }

        }
    }

}