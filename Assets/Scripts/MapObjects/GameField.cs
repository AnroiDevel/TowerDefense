using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    public class GameField : MonoBehaviour
    {
        [SerializeField] private int _width = 20;
        [SerializeField] private int _height = 10;
        [SerializeField] private GameObject _groundFieldPrefab;
        [SerializeField] private Transform _transform;
        [SerializeField] private GameObject _towerPlacePrefab;

        [SerializeField] private Vector2Int[] _towerPosition;

        private Map _map;
        private GameObject[,] _fields;


        private void Start()
        {
            InitMap();
        }

        private void InitMap()
        {
            _map = new Map(_width, _height);
            _fields = new GameObject[_width, _height];
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    var field = Instantiate(_groundFieldPrefab, _transform);
                    field.transform.position = new Vector2(x, y);
                    _fields[x, y] = field;
                }
            }

            var position = Camera.main.ScreenToWorldPoint(_transform.position);
            position.z = 0;
            _transform.position = position;

            foreach (var tp in _towerPosition)
                Instantiate(_towerPlacePrefab, _fields[tp.x, tp.y].transform);
        }

        public void ActivateNavigationGrid(float scale)
        {
            Vector2 newScale = new Vector2(1 - scale, 1 - scale);
            foreach (var field in _fields)
                field.transform.localScale = newScale;
        }
    }

}