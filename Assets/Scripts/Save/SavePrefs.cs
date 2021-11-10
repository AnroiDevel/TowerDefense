using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace TowerDefese
{
    public class SavePrefs : MonoBehaviour
    {
        public Slider GridSlider;
        public Slider EnemySpeedSlider;


        private void Start()
        {
            if (PlayerPrefs.HasKey("GridSize"))
            {
                GridSlider.value = PlayerPrefs.GetFloat("GridSize");
                EnemySpeedSlider.value = PlayerPrefs.GetFloat("EnemySpeed");
            }
        }

        public void SaveGridSize()
        {
            PlayerPrefs.SetFloat("GridSize", GridSlider.value);
        }

        public void SaveEnemySpeed()
        {
            PlayerPrefs.SetFloat("EnemySpeed", EnemySpeedSlider.value);
        }
    }

}