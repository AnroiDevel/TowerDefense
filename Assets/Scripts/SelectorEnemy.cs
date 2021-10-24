using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


namespace TowerDefese
{
    public class SelectorEnemy : MonoBehaviour, IPointerDownHandler
    {
        private Image _selectableImg;

        private void Start()
        {
            _selectableImg = GetComponent<Image>();
        }

        public Action<Image> Selected;
        public void OnPointerDown(PointerEventData eventData)
        {
            Selected?.Invoke(_selectableImg);
        }
    }

}