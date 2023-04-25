using System;

namespace Locust.Base
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class OrderAttribute : Attribute
    {
        public int Value { get; set; }
        public OrderAttribute(int value)
        {
            Value = value;
        }
    }
}
