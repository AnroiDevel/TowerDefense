using System;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    [Serializable]
    public class SaveData
    {
        public List<Vector3> TowersPositions;
        public List<Vector3> FieldsPositions;

        public Vector3 StartPosition;
        public Vector3 EndPosition;

    }

}