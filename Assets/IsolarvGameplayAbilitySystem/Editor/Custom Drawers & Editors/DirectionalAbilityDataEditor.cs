using IsolarvGAS.Runtime;
using UnityEditor;

namespace IsolarvGAS.Editor
{
    [CustomEditor(typeof(DirectionalAbilityData), true)]
    public class DirectionalAbilityDataEditor : BaseAbilityDataEditor
    {
        protected override void DrawGUI()
        {
            DrawActorGUI();
            DrawDirectionalAbilityGUI();
            DrawBaseAbilityInfoGUI();
        }

        void DrawDirectionalAbilityGUI()
        {
            EditorGUILayout.LabelField("Directional Ability Info", LabelStyle);

            // Add custom GUI elements for DirectionalAbilityData here
        }
    }
}