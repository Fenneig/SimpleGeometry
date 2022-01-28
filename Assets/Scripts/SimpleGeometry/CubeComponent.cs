namespace SimpleGeometry
{
    public class CubeComponent : Figure
    {
        public override void OnClick()
        {
            Capture();
        }

        public void Capture()
        {
            Pool.Instance.Capture(this);
        }
    }
}