using UnityEngine;


namespace TowerDefese
{
    public class Tower : BaseView<TowerModel, TowerController>
    {
        private TargetDetector _targetDetector;
        private Gun _gun;

        private void Start()
        {
            _gun = GetComponentInChildren<Gun>();
            _targetDetector = GetComponentInChildren<TargetDetector>();
        }

        private void Update()
        {
            if (_targetDetector.Target != null)
            {
                var target = _targetDetector.Target;
                Vector2 dir = target.position - transform.position;
                transform.up = Vector2.MoveTowards(transform.up, dir, Time.deltaTime * Model.RotationSpeed);
                var angle = Vector2.Angle(transform.up, dir);
                if (angle < 10)
                    _gun.Shot();
            }
        }
    }
}