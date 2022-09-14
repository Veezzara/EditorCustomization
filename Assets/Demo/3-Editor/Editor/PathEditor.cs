using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Path))]
[CanEditMultipleObjects]
public class PathEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
    }

    public void OnSceneGUI()
    {
        var path = (Path) target;
        var points = path.points;

        for (int i = 0; i < points.Length; i++)
        {
            var point = points[i];

            var newPointPosition = Handles.PositionHandle(point, Quaternion.identity);
            points[i] = newPointPosition;

            var nextIndex = (i + 1) % points.Length;
            var nextPoint = points[nextIndex];

            Handles.DrawLine(point, nextPoint);
            Handles.Label(newPointPosition, (i + 1).ToString());
        }
    }
}
