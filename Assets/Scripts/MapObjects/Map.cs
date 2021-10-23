using UnityEngine;


namespace TowerDefese
{
    public class Map
    {
        private Vector2[,] _cells;

        private int _width;
        private int _height;


        public Map(int widthCells, int heightCells)
        {
            _width = widthCells;
            _height = heightCells;
            _cells = new Vector2[widthCells, heightCells];
        }

        public void SetCell(int x, int y, Vector2 value)
        {
            if (x < 0 || x >= _width || y < 0 || y >= _height)
                return;
            _cells[x, y] = value;
        }

        public Vector2 GetCell(int x, int y)
        {
            return _cells[x, y];
        }
    }

}