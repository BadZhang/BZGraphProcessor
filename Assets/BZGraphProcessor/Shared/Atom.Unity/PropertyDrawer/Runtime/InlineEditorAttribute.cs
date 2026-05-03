
using UnityEngine;
using System;

namespace BZGraphProcessor.Shared.Unity
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class InlineEditorAttribute : UnityEngine.PropertyAttribute { }
}
