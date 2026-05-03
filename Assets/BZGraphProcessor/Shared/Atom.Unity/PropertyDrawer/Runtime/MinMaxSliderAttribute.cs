
using UnityEngine;
using System;

namespace BZGraphProcessor.Shared.Unity
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true,Inherited = true)]
    public class MinMaxSliderAttribute : UnityEngine.PropertyAttribute {

        public float min, max;
        public float fieldWidth = 50;
        public MinMaxSliderAttribute(float min,float max)
        {
            this.min = min;
            this.max = max; 
        }
    }
}
