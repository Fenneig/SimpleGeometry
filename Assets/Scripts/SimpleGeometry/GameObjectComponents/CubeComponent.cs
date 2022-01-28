namespace SimpleGeometry.GameObjectComponents
{
    public class CubeComponent : Figure
    {
        private void Start()
        {
            IsMoveable = true;
        }

        public override void OnClick()
        {
            if (Player.Instance.IsHoldingFigure()) Player.Instance.InvokeFigureAction(this);
            else Player.Instance.Capture(this);
        }
    }
}