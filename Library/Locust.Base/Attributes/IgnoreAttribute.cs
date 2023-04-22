using System;

namespace Locust.Base
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class IgnoreAttribute : Attribute
    {
    }
}
