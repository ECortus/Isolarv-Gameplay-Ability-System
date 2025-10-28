using IsolarvGAS.Runtime;
using UnityEditor;

namespace IsolarvGAS.Editor
{
    [CustomEditor(typeof(PointedAbilityData), true)]
    public class PointedAbilityDataEditor : BaseAbilityDataEditor
    {
        protected override void DrawGUI()
        {
            DrawActorGUI();
            DrawPointedAbilityGUI();
            DrawBaseAbilityInfoGUI();
        }

        void DrawPointedAbilityGUI()
        {
            EditorGUILayout.LabelField("Pointed Ability Info", LabelStyle);

            // Add custom GUI elements for PointedAbilityData here
        }
    }
}