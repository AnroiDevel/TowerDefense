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
        private string _name;

        private void Start()
        {
            _selectableImg = GetComponent<Image>();
            _name = name;
        }

        public Action<Image,string> Selected;
        public void OnPointerDown(PointerEventData eventData)
        {
            Selected?.Invoke(_selectableImg, _name);
        }
    }

}