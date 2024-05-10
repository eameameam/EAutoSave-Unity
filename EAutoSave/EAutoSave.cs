using UnityEditor;
using UnityEditor.Toolbars;
using UnityEngine;
using UnityEngine.UIElements;

namespace Editor
{
    [EditorToolbarElement("EToolbar/EAutoSave", typeof(SceneView))]
    public class EAutoSave : EditorToolbarToggle
    {
        static double nextSaveTime = 0;
        static Object[] cachedSelectedObjects;

        public EAutoSave()
        {
            icon = EditorGUIUtility.IconContent("SaveActive").image as Texture2D;
            tooltip = "Toggle AutoSave for selected objects.";

            value = EditorPrefs.GetBool("AutoSaveEnabled", false);

            this.RegisterValueChangedCallback(evt =>
            {
                EditorPrefs.SetBool("AutoSaveEnabled", evt.newValue);
                if (evt.newValue)
                {
                    cachedSelectedObjects = Selection.objects; 
                    nextSaveTime = EditorApplication.timeSinceStartup;
                    Debug.LogWarning("AutoSave enabled");
                }
                else
                {
                    cachedSelectedObjects = null; 
                    Debug.LogWarning("AutoSave disabled");
                }
            });

            EditorApplication.update += OnEditorUpdate;
        }

        void OnEditorUpdate()
        {
            if (value && EditorApplication.timeSinceStartup >= nextSaveTime)
            {
                float interval = EditorPrefs.GetFloat("AutoSaveInterval", 300f);
                nextSaveTime = EditorApplication.timeSinceStartup + interval;
                SaveCachedAssets();
            }
        }

        void SaveCachedAssets()
        {
            Debug.Log("Auto-saved following Assets:");

            foreach (Object obj in cachedSelectedObjects)
            {
                EditorUtility.SetDirty(obj);
                Debug.Log(AssetDatabase.GetAssetPath(obj));
            }
            AssetDatabase.SaveAssets();
        }
    }
}