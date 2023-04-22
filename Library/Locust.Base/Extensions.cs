using System;

namespace Locust.Base
{
    public static class Extensions
    {
        public static T Activate<T>(this IObjectActivator activator, params object[] args)
        {
            return (T)activator.Activate(typeof(T), args);
        }
        public static T SafeActivate<T>(this IObjectActivator activator, params object[] args)
        {
            var result = activator.SafeActivate(typeof(T), args);

            try
            {
                return (T)result;
            }
            catch
            {
                return default(T);
            }
        }
        public static bool TryActivate<T>(this IObjectActivator activator, out T result, out Exception exception, params object[] args)
        {
            result = default(T);

            if (activator.TryActivate(typeof(T), out object value, out exception, args))
            {
                try
                {
                    result = (T)value;

                    return true;
                }
                catch (Exception ex)
                {
                    exception= ex;

                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool TryActivate<T>(this IObjectActivator activator, out T result, params object[] args)
        {
            return activator.TryActivate<T>(out result, out Exception ex, args);
        }
    }
}
