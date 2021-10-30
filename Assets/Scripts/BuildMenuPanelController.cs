using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;


namespace TowerDefese
{
    public class BuildMenuPanelController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        private InputConroller _inputs;
        private bool _clickOverMenuPanel = true;
        private PositionConstraint _positionConstraint;
        [SerializeField] private GameObject _towerPrefab;

        private void Awake()
        {
            _inputs = new InputConroller();
            _inputs.Main.ClickOverBuildMenu.performed += context => gameObject.SetActive(!_clickOverMenuPanel);

        }

        private void Start()
        {
            _positionConstraint = GetComponent<PositionConstraint>();
        }

        private void OnEnable()
        {
            _inputs.Enable();
        }

        private void OnDisable()
        {
            _inputs.Disable();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _clickOverMenuPanel = false;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _clickOverMenuPanel = true;
        }

        public void CreateTower()
        {
            var towerPos = _positionConstraint.GetSource(0).sourceTransform;
            Instantiate(_towerPrefab, towerPos.position, Quaternion.identity);
            gameObject.SetActive(false);

        }

    }

}