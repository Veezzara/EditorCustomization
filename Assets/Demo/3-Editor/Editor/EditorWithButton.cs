using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SomeObjectWithEditor))]
[CanEditMultipleObjects]
public class EditorWithButton : Editor
{
    public override void OnInspectorGUI()
    {
        GUILayout.BeginVertical();
        if (GUILayout.Button("Move to world origin!"))
        {
            MoveToWorldOrigin();
        }
        GUILayout.EndVertical();
        base.OnInspectorGUI();
    }

    public void MoveToWorldOrigin()
    {
        var target = serializedObject.targetObject as SomeObjectWithEditor;
        var transform = target.transform;
        transform.localPosition = Vector3.zero;
    }
}
