using IsolarvGAS.Runtime;
using UnityEditor;

namespace IsolarvGAS.Editor
{
    [CustomEditor(typeof(TargetedAbilityData), true)]
    public class TargetedAbilityDataEditor : PointedAbilityDataEditor
    {
        protected override void DrawGUI()
        {
            DrawActorGUI();

            DrawPointedAbilityGUI();
            DrawTargetedAbilityGUI();

            DrawBaseAbilityInfoGUI();
        }

        void DrawTargetedAbilityGUI()
        {
            EditorGUILayout.LabelField("Targeted Ability Info", LabelStyle);

            if (pointedAbilityTypeProperty.enumValueIndex == (int)PointedAbilityData.EPointedAbilityType.Projectile)
            {
                DrawProperty("projectileFollowsTarget");
            }
            else if (pointedAbilityTypeProperty.enumValueIndex == (int)PointedAbilityData.EPointedAbilityType.Instant)
            {
                EditorGUILayout.LabelField("No additional properties for Instant targeted abilities.");
            }
            else
            {
                throw new System.NotImplementedException("Unhandled Pointed Ability Type in TargetedAbilityDataEditor.");
            }
        }
    }
}