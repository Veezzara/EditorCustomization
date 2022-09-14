using System;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SelectMicrophoneAttribute))]
public class SelectMicrophonePropertyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var selectedDevice = property.stringValue;
        var selectedIndex = Array.IndexOf(Microphone.devices, selectedDevice);
        if (selectedIndex == -1) selectedIndex = 0;
        var newSelected = EditorGUI.Popup(position, label.text, selectedIndex, Microphone.devices);
        try
        {
            property.stringValue = Microphone.devices[newSelected];
        }
        catch { }
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label);
    }
}
