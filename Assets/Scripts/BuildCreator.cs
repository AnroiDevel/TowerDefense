using UnityEngine;
using UnityEngine.Animations;


namespace TowerDefese
{
    public class BuildCreator : MonoBehaviour
    {
        private Transform _buildMenuTransform;
        private ConstraintSource constraintSource;

        public ConstraintSource ConstraintSource
        {
            get
            {
                return Constraint();
            }
        }

        private ConstraintSource Constraint()
        {
            var c = new ConstraintSource();
            _buildMenuTransform = GetComponent<Transform>();
            c.sourceTransform = _buildMenuTransform;
            c.weight = 1.0f;
            constraintSource = c;
            return constraintSource;
        }
    }

}