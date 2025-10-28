using IsolarvGAS.Runtime;
using UnityEditor;

namespace IsolarvGAS.Editor
{
    [CustomEditor(typeof(TargetedAbilityData), true)]
    public class TargetedAbilityDataEditor : BaseAbilityDataEditor
    {
        protected override void DrawGUI()
        {
            DrawActorGUI();
            DrawTargetedAbilityGUI();
            DrawBaseAbilityInfoGUI();
        }

        void DrawTargetedAbilityGUI()
        {
            EditorGUILayout.LabelField("Targeted Ability Info", LabelStyle);

            // Add custom GUI elements for TargetedAbilityData here
        }
    }
}