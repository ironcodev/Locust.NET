using System;

namespace Locust.Base
{
    public interface IObjectActivator
    {
        object Activate(Type type, params object[] args);
        object SafeActivate(Type type, params object[] args);
        bool TryActivate(Type type, out object result, out Exception exception, params object[] args);
        bool TryActivate(Type type, out object result, params object[] args);
    }
}
