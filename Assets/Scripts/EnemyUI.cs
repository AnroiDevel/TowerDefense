using System;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;


namespace TowerDefese
{
    public class EnemyUI : MonoBehaviour
    {
        [SerializeField] private GameObject _enemyUIPrefab;
        private GameObject _enemyUI;

        private Image _healthImage;
        public void CreateInfoUI(IEnemy enemy)
        {
            var canvas = GameObject.Find("Canvas");
            _enemyUI = Instantiate(_enemyUIPrefab, canvas.transform);

            var name = _enemyUI.transform.Find("Name").GetComponentInChildren<Text>();
            _healthImage = _enemyUI.transform.Find("LifeImage").GetComponent<Image>();
            name.text = enemy.Name;
            enemy.GetDamageEvent += SetHealthValue;
            _enemyUI.AddComponent<ParentConstraint>();
            var parentConstraint = _enemyUI.GetComponent<ParentConstraint>();
            parentConstraint.AddSource(new ConstraintSource());
            var soursetransform = parentConstraint.GetSource(0);
            soursetransform.sourceTransform = enemy.transform;
            soursetransform.weight = 1.0f;
            parentConstraint.SetSource(0, soursetransform);
            parentConstraint.constraintActive = true;
        }

        private void SetHealthValue(float value)
        {
            _healthImage.fillAmount = value / 100;
            if (value <= 0)
                _enemyUI.SetActive(false);
        }
    }

}