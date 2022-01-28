using UnityEditor;
using SimpleGeometry.GameObjectComponents;

[CustomEditor(typeof(Figure), true)]
[CanEditMultipleObjects]
public class FigureEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var figure = (Figure) target;
        figure.Resize();
    }
}