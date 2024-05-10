using UnityEditor.Overlays;
using UnityEditor;

namespace Editor
{
    [Overlay(typeof(SceneView), "", true)]
    public class EAutoSaveControlOverlay : ToolbarOverlay
    {
        public EAutoSaveControlOverlay() : base("EToolbar/EAutoSave")
        {
        }
    }
}
