using System;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    [Serializable]
    public class SaveData
    {
        public List<Vector2Int> TowersPositions;

        public SaveData()
        {
            TowersPositions = new List<Vector2Int>();
        }
    }

}