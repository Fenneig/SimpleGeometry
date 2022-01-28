using UnityEngine;
using UnityEditor;
using SimpleGeometry;

[CustomEditor(typeof(Figure), true)]
[CanEditMultipleObjects]
public class FigureEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var figure = (Figure) target;
        figure.transform.localScale = Vector3.one * figure.Size;
    }
}