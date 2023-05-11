using System;

namespace Locust.Base
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class DefaultAttribute: Attribute
    {
        private object value;
        public object Value { get {  return value; } }
        public DefaultAttribute(object value)
        {
            this.value = value;
        }
    }
}
