using System.Collections.Generic;
using System.IO;
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
        [SerializeField] private string _pathSave;

        private List<Vector3> _towersPositions = new List<Vector3>();
        private Vector3 _startPosition;

        private GameObject[,] _fields;
        private List<Vector3> _fieldsPositions = new List<Vector3>();


        private List<GameObject> _towers = new List<GameObject>();

        private void Start()
        {
            _startPosition = _transform.position;
            InitMap();
        }

        public void InitMap()
        {
            if (_fields != null)
            {
                foreach (var field in _fields)
                    Destroy(field);
                _transform.position = _startPosition;
            }

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

            _transform.position = new Vector3(-_width / 2, -_height / 2, 0);

            foreach (var field in _fields)
                _fieldsPositions.Add(field.transform.position);

            foreach (var tp in _towerPosition)
            {
                var tower = Instantiate(_towerPlacePrefab, _fields[tp.x, tp.y].transform);
                tower.GetComponent<SpriteRenderer>().sortingOrder--;
                _towersPositions.Add(tower.transform.position);
                _towers.Add(tower);
            }


        }

        public void ActivateNavigationGrid(float scale)
        {
            Vector2 newScale = new Vector2(1 - scale, 1 - scale);
            if (_fields != null)
                foreach (var field in _fields)
                    field.transform.localScale = newScale;
        }

        public void SaveGameField()
        {
            string path = Application.dataPath + _pathSave;
            SaveData data = new SaveData();
            data.TowersPositions = _towersPositions;
            data.FieldsPositions = _fieldsPositions;
            string value = JsonUtility.ToJson(data);
            File.WriteAllText(path, value);
        }
    }

}