using IsolarvGAS.Runtime;
using UnityEditor;

namespace IsolarvGAS.Editor
{
    [CustomEditor(typeof(PointedAbilityData), true)]
    public class PointedAbilityDataEditor : BaseAbilityDataEditor
    {
        protected SerializedProperty pointedAbilityTypeProperty { get; private set; }

        protected override void DrawGUI()
        {
            DrawActorGUI();
            DrawPointedAbilityGUI();
            DrawBaseAbilityInfoGUI();
        }

        protected void DrawPointedAbilityGUI()
        {
            EditorGUILayout.LabelField("Pointed Ability Info", LabelStyle);

            pointedAbilityTypeProperty = serializedObject.FindProperty("pointedAbilityType");
            DrawProperty(pointedAbilityTypeProperty);

            if (pointedAbilityTypeProperty.enumValueIndex == (int)PointedAbilityData.EPointedAbilityType.Projectile)
            {
                EditorGUILayout.Space(5);

                DrawProperty("projectilePrefab");
                DrawProperty("projectileSpeed");
                DrawProperty("projectileIsOneHit");
                DrawProperty("projectileAffectsOnRadius");
                DrawProperty("projectileRadiusOfAffect");
            }
            else if (pointedAbilityTypeProperty.enumValueIndex == (int)PointedAbilityData.EPointedAbilityType.Instant)
            {
                EditorGUILayout.LabelField("No additional properties for Instant pointed abilities.");
            }
            else
            {
                throw new System.NotImplementedException("Unhandled Pointed Ability Type in PointedAbilityDataEditor.");
            }
        }
    }
}