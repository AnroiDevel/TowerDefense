using System;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;


namespace TowerDefese
{
    public class EnemyUI : MonoBehaviour
    {
        [SerializeField] private GameObject _enemyUIPrefab;

        public void CreateInfoUI(IEnemy enemy)
        {
            var canvas = GameObject.Find("Canvas");
            var enemyUI = Instantiate(_enemyUIPrefab, canvas.transform);

            var name = enemyUI.transform.Find("Name").GetComponentInChildren<Text>();
            var healthImage = enemyUI.transform.Find("LifeImage").GetComponent<Image>();
            name.text = enemy.Name;
            enemy.GetDamageEvent += SetHealthValue;
            enemyUI.AddComponent<ParentConstraint>();
            var parentConstraint = enemyUI.GetComponent<ParentConstraint>();
            parentConstraint.AddSource(new ConstraintSource());
            var soursetransform = parentConstraint.GetSource(0);
            soursetransform.sourceTransform = enemy.transform;
            soursetransform.weight = 1.0f;
            parentConstraint.SetSource(0, soursetransform);
            parentConstraint.constraintActive = true;

            void SetHealthValue(float value)
            {
                Debug.Log(value);
                if (value <= 0)
                    enemyUI.SetActive(false);
                healthImage.fillAmount = value / 100;
            }

        }

    }

}