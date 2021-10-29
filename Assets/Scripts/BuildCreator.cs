using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;


namespace TowerDefese
{
    public class BuildCreator: MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] public GameObject _buildMenuUI;
        private Transform _buildMenuTransform;

        private void Start()
        {
            _buildMenuTransform = GetComponent<Transform>();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _buildMenuUI.SetActive(true);
            var constraint = _buildMenuUI.GetComponent<PositionConstraint>();
            var c = constraint.GetSource(0);
            c.sourceTransform = _buildMenuTransform;
            c.weight = 1.0f;
            constraint.SetSource(0, c);
        }
    }

}