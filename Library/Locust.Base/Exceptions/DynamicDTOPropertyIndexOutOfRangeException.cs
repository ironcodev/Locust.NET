using System;

namespace Locust.Base
{
    public class DynamicDTOPropertyIndexOutOfRangeException : LocustException
    {
        public DynamicDTOPropertyIndexOutOfRangeException(int index) : base($"DTO object does not have a property at {index} index")
        {
        }
    }
}