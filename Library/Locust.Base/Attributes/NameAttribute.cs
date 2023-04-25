using System;

namespace Locust.Base
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class NameAttribute : Attribute
    {
        public string Value { get; set; }
        public NameAttribute(string value)
        {
            Value = value;
        }
    }
}
