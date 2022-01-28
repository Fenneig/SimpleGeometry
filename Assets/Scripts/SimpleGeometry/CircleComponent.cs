namespace SimpleGeometry
{
    public class CircleComponent : Figure
    {
        public override void OnClick()
        {
            if (Pool.Instance.IsHolidngFigure())
            {
                Pool.Instance.Figure.transform.position = transform.position;
            }
        }
    }
}