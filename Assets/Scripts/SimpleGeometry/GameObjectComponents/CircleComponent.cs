using UnityEngine.UI;

namespace SimpleGeometry.GameObjectComponents
{
    public class CircleComponent : Figure
    {
        public override void OnClick()
        {
            if (!Player.Instance.IsHoldingFigure()) return;
            if (!Player.Instance.Figure.IsMoveable) return;
            if (Player.Instance.Figure.Size > Size) return;
            
            Player.Instance.Figure.transform.position = transform.position;
            var image = Player.Instance.Figure.GetComponent<Image>();
            image.raycastTarget = false;
            Player.Instance.Release();
            Player.Instance.Moves++;
        }
    }
}