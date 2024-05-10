using UnityEditor.Overlays;
using UnityEditor;

[Overlay(typeof(SceneView), "", true)]
public class EAutoSaveControlOverlay : ToolbarOverlay
{
    public EAutoSaveControlOverlay() : base("CustomToolbar/AutoSaveIndicator")
    {
    }
}
