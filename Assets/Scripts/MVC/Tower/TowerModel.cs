using System;
using UnityEngine;


namespace TowerDefese
{
    [Serializable]
    public class TowerModel : BaseModel
    {
        [SerializeField] private float _rotationSpeed = 4.0f;

        public float RotationSpeed { get => _rotationSpeed; }
    }
}