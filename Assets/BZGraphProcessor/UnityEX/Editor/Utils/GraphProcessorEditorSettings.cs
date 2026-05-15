#if UNITY_EDITOR
using System.Runtime.CompilerServices;
using BZGraphProcessor.Shared.UnityEditors;

namespace BZGraphProcessor.Editor
{
    public class GraphProcessorEditorSettings
    {
        public static EditorPrefsVariable<bool> MiniMapActive { get; } = new(GetKey());
        public static EditorPrefsVariable<bool> GridSnapActive { get; } = new(GetKey(), true);
        public static EditorPrefsVariable<int> GridSnapSize { get; } = new(GetKey(), 16);
        public static EditorPrefsVariable<bool> InspectorActive { get; } = new(GetKey(), true);
        public static EditorPrefsVariable<bool> ItemLibraryActive { get; } = new(GetKey(), false);
        public static EditorPrefsVariable<int> CommandHistoryLimit { get; } = new(GetKey(), 200);

        public static string GetKey([CallerMemberName] string memberName = null)
        {
            return $"{nameof(GraphProcessorEditorSettings)}.{memberName}";
        }
    }
}
#endif
