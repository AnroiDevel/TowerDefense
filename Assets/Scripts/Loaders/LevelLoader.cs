using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace TowerDefese
{
    public class LevelLoader : MonoBehaviour
    {
        [SerializeField] private GameObject _towerPlacePrefab;
        [SerializeField] private string _pathLoad;
        [SerializeField] private GameObject _road;
        [SerializeField] private GameObject _fieldPrefab;
        private void Start()
        {
            if (_road)
                Instantiate(_road);
            LoadGameField();
        }

        public void LoadLevel(string nameLevel)
        {
            SceneManager.LoadScene(nameLevel);
        }

        private void GroundCreate(int width, int height)
        {

        }

        public void LoadGameField()
        {
            if (_pathLoad == string.Empty)
                Debug.LogError("Не указан путь сохраненного файла");
            string path = Application.dataPath + _pathLoad;
            if (!File.Exists(path))
                Debug.LogError("Файл отсутствует");
            var jsonDataAsBytes = File.ReadAllBytes(path);
            string jsonData = Encoding.ASCII.GetString(jsonDataAsBytes);
            SaveData returnedData = new SaveData();
            JsonUtility.FromJsonOverwrite(jsonData, returnedData);
            var pos = returnedData.TowersPositions;

            foreach (var position in pos)
            {
                var towerPlace = Instantiate(_towerPlacePrefab);
                towerPlace.transform.position = position;
            }
            foreach (var position in returnedData.FieldsPositions)
                Instantiate(_fieldPrefab, position, Quaternion.identity);
        }

    }


}