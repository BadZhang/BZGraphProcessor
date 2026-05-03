
using UnityEngine;
using System;

namespace BZGraphProcessor.Shared.Unity
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class ReadOnlyAttribute : UnityEngine.PropertyAttribute { }
}
