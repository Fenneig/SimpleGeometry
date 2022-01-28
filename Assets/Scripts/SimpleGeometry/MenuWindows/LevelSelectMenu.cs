using UnityEngine;
using UnityEngine.SceneManagement;

namespace SimpleGeometry.MenuWindows
{
    public class LevelSelectMenu : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenu;

        public void OnStartGame()
        {
            SceneManager.LoadScene("HUD", LoadSceneMode.Additive);
        }

        public void OnReturn()
        {
            _mainMenu.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}