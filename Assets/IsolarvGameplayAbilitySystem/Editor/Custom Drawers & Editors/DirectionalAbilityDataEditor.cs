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

            var directionalAbilityTypeProperty = serializedObject.FindProperty("directionalAbilityType");
            DrawProperty(directionalAbilityTypeProperty);

            if (directionalAbilityTypeProperty.enumValueIndex == (int)DirectionalAbilityData.EDirectionalAbilityType.Projectile)
            {
                EditorGUILayout.Space(5);

                DrawProperty("projectilePrefab");
                DrawProperty("projectileSpeed");
                DrawProperty("projectileFlyingDistance");
                DrawProperty("projectileIsOneHit");
                DrawProperty("projectileAffectsOnRadius");
                DrawProperty("projectileRadiusOfAffect");
            }
            else if (directionalAbilityTypeProperty.enumValueIndex == (int)DirectionalAbilityData.EDirectionalAbilityType.Ray)
            {
                EditorGUILayout.Space(5);

                DrawProperty("rayPrefab");
                DrawProperty("raySpeed");
                DrawProperty("rayLength");
                DrawProperty("rayWidth");
            }
            else
            {
                throw new System.NotImplementedException("Unhandled Directional Ability Type in DirectionalAbilityDataEditor.");
            }
        }
    }
}