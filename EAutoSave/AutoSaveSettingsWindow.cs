using UnityEditor;
using UnityEngine;

public class EAutoSaveSettingsWindow : EditorWindow
{
    [MenuItem("Escripts/AutoSave Settings")]
    public static void ShowWindow()
    {
        GetWindow(typeof(EAutoSaveSettingsWindow), false, "AutoSave Settings");
    }

    void OnGUI()
    {
        float autoSaveInterval = EditorGUILayout.FloatField("Interval (sec): ", EditorPrefs.GetFloat("AutoSaveInterval", 300f));
        if (GUILayout.Button("Apply"))
        {
            EditorPrefs.SetFloat("AutoSaveInterval", autoSaveInterval);
            Debug.Log($"AutoSave interval set to {autoSaveInterval} seconds.");
        }
    }
}