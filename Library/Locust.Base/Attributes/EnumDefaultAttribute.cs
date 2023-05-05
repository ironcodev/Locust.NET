using System;

namespace Locust.Base
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
    public class EnumDefaultAttribute: Attribute
    {
        private object value;
        public object Value { get {  return value; } }
        public EnumDefaultAttribute(object value)
        {
            this.value = value;
        }
    }
}
