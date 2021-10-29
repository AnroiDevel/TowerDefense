using UnityEngine;
using UnityEngine.UI;

namespace TowerDefese
{
    public class PlayerUI : MonoBehaviour
    {
        [SerializeField] private Text _scoreText;
        [SerializeField] private int _startGolds = 100;
        public static PlayerData Data;

        private void Start()
        {
            Data = new PlayerData();
            Data.ChangeScore += SetScoreUI;
            Data.Score = _startGolds;
        }

        private void SetScoreUI(int value)
        {
            _scoreText.text = value.ToString();
        }
    }

}