using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace TowerDefese
{
    public class LevelLoader : MonoBehaviour
    {
        [SerializeField] private GameObject _towerPlacePrefab;

        public void LoadLevel(string nameLevel)
        {
            SceneManager.LoadScene(nameLevel);
        }

        public void LoadGameField()
        {
            string path = Application.dataPath + "/Resources/Json/text.json";
            var jsonDataAsBytes = File.ReadAllBytes(path);
            string jsonData = Encoding.ASCII.GetString(jsonDataAsBytes);
            SaveData returnedData = new SaveData();
            JsonUtility.FromJsonOverwrite(jsonData, returnedData);
            var pos = returnedData.TowersPositions;
            foreach (var position in pos)
            {
                var towerPlace = Instantiate(_towerPlacePrefab);
                towerPlace.transform.position = (Vector2)position;
            }
        }

    }

}