using System;

namespace Locust.Base
{
    public class DynamicDTOPropertyNotFoundException : LocustException
    {
        public DynamicDTOPropertyNotFoundException(string name): base($"DTO object does not have a {name} property")
        {
        }
    }
}