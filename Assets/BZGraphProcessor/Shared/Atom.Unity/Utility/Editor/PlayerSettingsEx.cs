#if UNITY_EDITOR



using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace BZGraphProcessor.Shared.UnityEditors
{
    public static class PlayerSettingsEx
    {
        public static void OpenDefineSymbols(List<string> defines, BuildTargetGroup targetGroup)
        {
            foreach (var def in defines)
            {
                if (def.Contains(";"))
                    throw new InvalidOperationException();
            }

            var defs = new List<string>(PlayerSettings.GetScriptingDefineSymbolsForGroup(targetGroup).Split(';'));

            foreach (var def in defines)
            {
                if (def.Contains(";"))
                    throw new InvalidOperationException();
                if (defs.Contains(def.Trim()))
                    defs.Add(def.Trim());
            }

            PlayerSettings.SetScriptingDefineSymbolsForGroup(targetGroup, string.Join(";", defs));
        }

        public static void CloseDefineSymbols(List<string> defines, BuildTargetGroup targetGroup)
        {
            foreach (var def in defines)
            {
                if (def.Contains(";"))
                    throw new InvalidOperationException();
            }

            var defs = new List<string>(PlayerSettings.GetScriptingDefineSymbolsForGroup(targetGroup).Split(';'));

            foreach (var def in defines)
            {
                if (defs.Contains(def.Trim()))
                    defs.Remove(def.Trim());
            }

            PlayerSettings.SetScriptingDefineSymbolsForGroup(targetGroup, string.Join(";", defs));
        }
    }
}
#endif