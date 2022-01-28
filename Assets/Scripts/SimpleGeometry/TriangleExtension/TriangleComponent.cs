using SimpleGeometry.GameObjectComponents;

namespace SimpleGeometry.TriangleExtension
{
    public class TriangleComponent : Figure
    {
        private void Start()
        {
            if (!Player.Instance.IsTriangleExtensionOn) Destroy(gameObject);
        }

        public override void OnClick()
        {
            Player.Instance.Capture(this);
            Player.Instance.OnFigureAction += ReduceTargetSize;
        }

        private void ReduceTargetSize(Figure target)
        {
            target.Size--;
            target.Resize();
        }
    }
}