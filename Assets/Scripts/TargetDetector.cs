using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    public class TargetDetector : MonoBehaviour
    {
        public Transform Target { get; private set; }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var target = collision.gameObject.GetComponent<SpriteRenderer>();
            if (target != null)
            {
                target.color = Color.red;
                Target = target.transform;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            var target = collision.gameObject.GetComponent<SpriteRenderer>();
            if (target != null)
            {
                target.color = Color.white;
                Target = null;
            }
        }

    }

}