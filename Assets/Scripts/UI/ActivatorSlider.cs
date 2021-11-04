using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


namespace TowerDefese
{
    public class ActivatorSlider : MonoBehaviour, IPointerDownHandler
    {
        private Slider _slider;

        private void Start()
        {
            _slider = transform.GetComponentInParent<Slider>();
            if (_slider.value >= 1)
                _slider.interactable = false;
        }
        public void OnPointerDown(PointerEventData eventData)
        {
            _slider.interactable = true;
        }
    }

}