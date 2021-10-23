using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    public class Tower : MonoBehaviour
    {
        [SerializeField] private TargetDetector _targetDetector;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private Gun _gun;

        private void Update()
        {
            if (_targetDetector.Target != null)
            {
                var target = _targetDetector.Target;

                //var angle = Vector2.Angle(Vector2.up, target.position - transform.position);
                //transform.eulerAngles = new Vector3(0f, 0f, transform.position.x < target.position.x ? -angle : angle);  //Áûסענûי ןמגמנמע

                Vector2 dir = target.position - transform.position;
                transform.up = Vector2.MoveTowards(transform.up, dir, Time.deltaTime * _rotationSpeed);
                var angle = Vector2.Angle(transform.up, dir);
                if (angle < 10)
                    _gun.Shot();
            }

        }
    }

}