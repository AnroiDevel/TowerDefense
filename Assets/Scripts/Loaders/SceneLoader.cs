using UnityEngine;
using UnityEngine.SceneManagement;


namespace TowerDefese
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadScene(string nameScene)
        {
            SceneManager.LoadScene(nameScene);
        }
    }


}