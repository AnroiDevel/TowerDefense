using System;
using UnityEngine;
using UnityEngine.UI;


namespace TowerDefese.TimeVersion
{
    [ExecuteInEditMode]
    public class TimeVersion : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Text>().text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
    }

}