using System;

namespace Locust.Base
{
    public class ObjectActivatorDefault : IObjectActivator
    {
        bool ActivateInternal(Type type, bool throwErrors, out object value, out Exception exception, params object[] args)
        {
            var result = false;

            do
            {
                value = null;
                exception = null;

                if (type == null || type.IsInterface || type.IsAbstract || (type.IsGenericType && type.IsGenericTypeDefinition))
                {
                    var msg = "";

                    if (type == null)
                    {
                        msg = "Cannot instantiate from null type";
                    }
                    else
                    {
                        if (type.IsInterface)
                        {
                            msg = $"Cannot instantiate from interface {type.Name}.";
                        }
                        else if (type.IsAbstract)
                        {
                            msg = $"Cannot instantiate from abstract class {type.Name}.";
                        }
                        else
                        {
                            msg = $"Cannot instantiate from open generic {type.Name}.";
                        }
                    }

                    exception = type == null ? new ArgumentException(msg, nameof(type)) : new ArgumentException(msg, nameof(type));
                    
                    if (throwErrors)
                    {
                        throw exception;
                    }

                    break;
                }

                try
                {
                    if (type == TypeHelper.TypeOfString && (args == null || args.Length == 0))
                    {
                        value = Activator.CreateInstance(TypeHelper.TypeOfString, new char[] { });
                        break;
                    }

                    if (type.IsArray && (args == null || args.Length == 0))
                    {
                        value = Activator.CreateInstance(type, 0);
                        break;
                    }

                    value = Activator.CreateInstance(type, args);
                }
                catch (Exception ex)
                {
                    exception = ex;
                    
                    if (throwErrors)
                    {
                        throw;
                    }
                }
            } while (false);

            return result;
        }
        public object Activate(Type type, params object[] args)
        {
            ActivateInternal(type, true, out object result, out Exception ex, args);

            return result;
        }

        public object SafeActivate(Type type, params object[] args)
        {
            ActivateInternal(type, false, out object result, out Exception ex, args);

            return result;
        }

        public bool TryActivate(Type type, out object result, out Exception exception, params object[] args)
        {
            return ActivateInternal(type, true, out result, out exception, args);
        }

        public bool TryActivate(Type type, out object result, params object[] args)
        {
            return ActivateInternal(type, true, out result, out Exception exception, args);
        }
    }
}
