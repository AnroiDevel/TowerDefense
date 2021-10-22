using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace TowerDefese
{
    public class SliderPanel : MonoBehaviour
    {
        private Slider _slider;
        private List<Image> _images;

        private void Start()
        {
            _slider = GetComponent<Slider>();
            var images = transform.GetComponentsInChildren<Image>();
            _images = new List<Image>();
            foreach (var image in images)
                if (image.name.Contains("Image"))
                    _images.Add(image);
        }

        public void RaycastControl()
        {
            if (_slider.value >= _slider.maxValue)
            {
                foreach (var image in _images)
                    image.raycastTarget = true;
                _slider.interactable = false;
            }
            else
                foreach (var image in _images)
                    image.raycastTarget = false;

        }
    }

}