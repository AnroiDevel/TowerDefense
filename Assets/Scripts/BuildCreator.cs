﻿using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;


namespace TowerDefese
{
    public class BuildCreator : MonoBehaviour, IPointerDownHandler
    {
        private GameObject _buildMenuUI;
        private Transform _buildMenuTransform;
        public ConstraintSource ConstraintSource;

        private void Awake()
        {

        }

        private void Start()
        {
            _buildMenuUI = FindObjectOfType<BuildMenuPanelController>().gameObject;

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