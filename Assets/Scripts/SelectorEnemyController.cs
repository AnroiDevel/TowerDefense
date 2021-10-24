using UnityEngine;
using UnityEngine.UI;


namespace TowerDefese
{
    public class SelectorEnemyController : MonoBehaviour
    {
        [SerializeField] private Color _defaultColor;
        [SerializeField] private Color _selectedColor;

        private SelectorEnemy[] _selectorEnemies;
        private Image[] _selectedImages;

        private void Start()
        {
            _selectorEnemies = GetComponentsInChildren<SelectorEnemy>();
            _selectedImages = new Image[_selectorEnemies.Length];
            for (int i = 0; i < _selectorEnemies.Length; i++)
            {
                _selectorEnemies[i].Selected += OnSelected;
                _selectedImages[i] = _selectorEnemies[i].GetComponent<Image>();
            }
            _selectorEnemies[0].Selected?.Invoke(_selectedImages[0]);
        }

        private void OnSelected(Image selectedImg)
        {
            foreach (var image in _selectedImages)
                image.color = _defaultColor;
            selectedImg.color = _selectedColor;
        }
    }

}