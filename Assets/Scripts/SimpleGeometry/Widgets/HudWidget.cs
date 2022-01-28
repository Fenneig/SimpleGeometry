using UnityEngine;
using UnityEngine.UI;

namespace SimpleGeometry.Widgets
{
    public class HudWidget : MonoBehaviour
    {
        [SerializeField] private Text _score;

        private string _defaultScoreText;

        private void OnEnable()
        {
            _defaultScoreText = _score.text;
            Player.Instance.OnChange += OnChange;
            OnChange();
        }

        private void OnChange()
        {
            _score.text = $"{_defaultScoreText} {Player.Instance.Moves}";
        }

        private void OnDestroy()
        {
            Player.Instance.OnChange -= OnChange;
        }
    }
}