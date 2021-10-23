using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    public class Dragable : MonoBehaviour
    {
        private void OnMouseDrag()
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition; 
        }
    }
}