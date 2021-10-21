using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    public class TargetDetector : MonoBehaviour
    {
        private List<Transform> _targets = new List<Transform>();
        public Transform Target 
        { 
            get 
            {
                if(_targets.Count > 0)
                    return _targets[0];
                return null;
            } 
        }



        private void OnTriggerEnter2D(Collider2D collision)
        {
            var target = collision.gameObject.GetComponent<SpriteRenderer>();
            if (target != null)
            {
                target.color = Color.red;
                _targets.Add(target.transform);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            var target = collision.gameObject.GetComponent<SpriteRenderer>();
            if (target != null)
            {
                target.color = Color.white;
                _targets.Remove(target.transform);
            }
        }

    }

}