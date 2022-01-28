using UnityEngine;
using UnityEngine.UI;

namespace SimpleGeometry.MenuWindows
{
    public class SettingsMenu : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenu;
        [SerializeField] private Toggle _toggle;

        public void OnReturn()
        {
            Player.Instance.IsTriangleExtensionOn = _toggle.isOn;
            _mainMenu.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}