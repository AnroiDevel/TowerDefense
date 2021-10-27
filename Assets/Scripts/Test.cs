using UnityEngine;
using UnityEngine.UI;

namespace TowerDefese
{
    public class Test : MonoBehaviour
    {
       [SerializeField] private Slider _slider;
        [SerializeField] private GameField _gameField;
        [SerializeField] private Slider _sliderTimeScale;

        public void GridActivation()
        {
            _gameField.ActivateNavigationGrid(_slider.value);
        }

        public void TimeScale()
        {
            Time.timeScale = _sliderTimeScale.value;
        }

    }

}