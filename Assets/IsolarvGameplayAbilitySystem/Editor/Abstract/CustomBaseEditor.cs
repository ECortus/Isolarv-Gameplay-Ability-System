using UnityEditor;
using UnityEngine;

namespace IsolarvGAS.Editor
{
    public abstract class CustomBaseEditor : UnityEditor.Editor
    {
        protected GUIStyle LabelStyle
        {
            get
            {
                GUIStyle style = new GUIStyle(EditorStyles.boldLabel);
                style.alignment = TextAnchor.LowerCenter;
                style.fontSize = 12;

                return style;
            }
        }

        protected void DrawProperty(string propertyName)
        {
            var property = serializedObject.FindProperty(propertyName);
            EditorGUILayout.PropertyField(property);
        }

        protected void DrawProperty(SerializedProperty property)
        {
            EditorGUILayout.PropertyField(property);
        }
    }
}