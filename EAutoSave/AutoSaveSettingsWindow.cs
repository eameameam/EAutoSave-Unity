using UnityEditor;
using UnityEngine;

namespace EAutoSave
{
    public class EAutoSaveSettingsWindow : EditorWindow
    {
        private float autoSaveInterval;

        [MenuItem("Escripts/AutoSave Settings")]
        public static void ShowWindow()
        {
            GetWindow(typeof(EAutoSaveSettingsWindow), false, "AutoSave Settings");
        }

        private void OnEnable()
        {
            autoSaveInterval = EditorPrefs.GetFloat("AutoSaveInterval", 300f);
        }

        void OnGUI()
        {
            autoSaveInterval = EditorGUILayout.FloatField("Interval (sec): ", autoSaveInterval);
            if (GUILayout.Button("Apply"))
            {
                EditorPrefs.SetFloat("AutoSaveInterval", autoSaveInterval);
                Debug.Log($"AutoSave interval set to {autoSaveInterval} seconds.");
            }
        }
    }
}
