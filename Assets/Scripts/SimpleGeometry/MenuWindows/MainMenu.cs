using UnityEngine;

namespace SimpleGeometry.MenuWindows
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private GameObject _settingsMenuWindow;
        [SerializeField] private GameObject _selectLevelWindow;

        public void OnStart()
        {
            _selectLevelWindow.SetActive(true);
            gameObject.SetActive(false);
        }

        public void OnSettings()
        {
            _settingsMenuWindow.SetActive(true);
            gameObject.SetActive(false);
        }

        public void OnExit()
        {
            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}