using UnityEngine;

namespace IsolarvGAS.Runtime
{
    public static class GASDebug
    {
        private static PackageSettings _packageSettings;
        private static PackageSettings PackageSettings
        {
            get
            {
                if (_packageSettings == null)
                {
                    if (_packageSettings == null)
                        _packageSettings = RuntimeUtils.Settings;
                }

                return _packageSettings;
            }
        }

        public static void Log(string message)
        {
            if (PackageSettings.ShowDebugLogs)
            {
                Debug.Log("[GAS] " + message);
            }
        }

        public static void LogWarning(string message)
        {
            if (PackageSettings.ShowDebugLogs)
            {
                Debug.LogWarning("[GAS] " + message);
            }
        }

        public static void LogError(string message)
        {
            if (PackageSettings.ShowDebugLogs)
            {
                Debug.LogError("[GAS] " + message);
            }
        }
    }
}