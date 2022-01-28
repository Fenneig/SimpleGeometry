using UnityEngine;
using UnityEngine.SceneManagement;

namespace SimpleGeometry.Components
{
    public class LevelLoaderComponent : MonoBehaviour
    {
        [SerializeField] private string _levelName;
        
        public void LoadLevel()
        {
            SceneManager.LoadScene(_levelName);
        }
    }
}