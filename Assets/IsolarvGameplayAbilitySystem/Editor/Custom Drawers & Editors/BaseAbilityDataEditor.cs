using System.Runtime.InteropServices;
using IsolarvGAS.Runtime;
using UnityEditor;
using UnityEngine;

namespace IsolarvGAS.Editor
{
    public abstract class BaseAbilityDataEditor : CustomBaseEditor
    {
        BaseAbilityData ability;

        void OnEnable()
        {
            ability = (BaseAbilityData)target;
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUI.BeginChangeCheck();

            DrawGUI();

            if (EditorGUI.EndChangeCheck())
            {
                serializedObject.ApplyModifiedProperties();
            }
        }

        protected abstract void DrawGUI();

        protected void DrawBaseAbilityInfoGUI()
        {
            DrawAffectInfoGUI();
            DrawCastingParametersGUI();

            DrawInputParametersGUI();

            DrawVisualEffectsGUI();
            DrawAudioEffectsGUI();
        }

        protected void DrawActorGUI()
        {
            EditorGUILayout.LabelField("Actor Info", LabelStyle);

            var idProperty = serializedObject.FindProperty("id");
            var nameProperty = serializedObject.FindProperty("abilityName");
            var descriptionProperty = serializedObject.FindProperty("description");

            GUI.enabled = false;

            var objectName = ability.name;
            var correctedName = string.IsNullOrEmpty(objectName) ? "<Unnamed Ability Data>" : objectName;
            var correctedId = "id_" + correctedName.ToLower().Replace(" ", "_");

            idProperty.stringValue = correctedId;
            nameProperty.stringValue = correctedName;

            DrawProperty(idProperty);
            DrawProperty(nameProperty);

            GUI.enabled = true;

            DrawProperty("icon");

            EditorGUILayout.LabelField("Description");
            var description = EditorGUILayout.TextArea(descriptionProperty.stringValue, GUILayout.Height(60));
            descriptionProperty.stringValue = description;
        }

        void DrawAffectInfoGUI()
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Base Affect Info", LabelStyle);

            var affectOnRadiusProperty = serializedObject.FindProperty("affectOnRadius");
            DrawProperty(affectOnRadiusProperty);

            if (affectOnRadiusProperty.boolValue)
            {
                DrawProperty("radiusOfAffect");
            }

            EditorGUILayout.Space(5);
            DrawProperty("affectAtSelf");
            DrawProperty("affectAtAllies");
            DrawProperty("affectAtEnemies");

            EditorGUILayout.Space(5);
            DrawProperty("affectableLayers");
        }

        void DrawCastingParametersGUI()
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Charges Usages Info", LabelStyle);

            DrawProperty("chargeUsageOnCast");
            DrawProperty("restoreChargesPerSecond");
            DrawProperty("maxCharges");
        }

        void DrawInputParametersGUI()
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Input Info", LabelStyle);

            var inputTypeProperty = serializedObject.FindProperty("inputType");
            DrawProperty(inputTypeProperty);

            var inputTypeEnum = (BaseAbilityData.EAbilityInputType)inputTypeProperty.enumValueIndex;
            if (inputTypeEnum == BaseAbilityData.EAbilityInputType.Hold)
            {
                DrawProperty("usageOnHoldPerSecond");
            }
        }

        void DrawVisualEffectsGUI()
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Visual Effects Info", LabelStyle);

            DrawProperty("onPreCastVFX");
            DrawProperty("onCastVFX");
            DrawProperty("onImpactVFX");
        }

        void DrawAudioEffectsGUI()
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Audio Effects Info", LabelStyle);

            DrawProperty("onPreCastSFX");
            DrawProperty("onCastSFX");
            DrawProperty("onImpactSFX");
        }
    }
}