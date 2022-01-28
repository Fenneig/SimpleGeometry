using UnityEngine;
using UnityEngine.UI;

namespace SimpleGeometry.Widgets
{
    public class HudWidget : MonoBehaviour
    {
        [SerializeField] private Text _score;
        [SerializeField] private Text _energy;
        
        private string _defaultScoreText;
        private string _defaultEnergyText;

        private void OnEnable()
        {
            DefaultInit();
            if (!Player.Instance.IsTriangleExtensionOn) _energy.gameObject.SetActive(false);
            OnChange();
            
        }

        private void DefaultInit()
        {
            _defaultScoreText = _score.text;
            _defaultEnergyText = _energy.text;
            Player.Instance.OnChange += OnChange;
            Player.Instance.Energy = Player.Instance.MaxEnergy;
        }

        private void OnChange()
        {
            _score.text = $"{_defaultScoreText} {Player.Instance.Moves}";
            _energy.text = $"{_defaultEnergyText} {Player.Instance.Energy} / {Player.Instance.MaxEnergy}";
        }

        private void OnDestroy()
        {
            Player.Instance.OnChange -= OnChange;
        }
    }
}