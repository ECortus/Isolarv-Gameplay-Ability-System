using UnityEngine;

namespace IsolarvGAS.Runtime
{
    [CreateAssetMenu(fileName = "Package Settings", menuName = "Isolarv/Gameplay Ability System/Package Settings", order = 0)]
    public class PackageSettings : ScriptableObject
    {
        [Header("Debug Settings")]
        [Tooltip("If enabled, the package will output debug logs to the console.")]
        public bool ShowDebugLogs = true;
    }
}