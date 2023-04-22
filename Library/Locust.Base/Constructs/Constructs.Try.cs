using System;

namespace Locust
{
    public static partial class Constructs
    {
        public static Exception TryOut(Action act)
        {
            Exception result = null;

            try
            {
                act();
            }
            catch (Exception e)
            {
                result = e;
            }

            return result;
        }
        public static bool Try(Action act)
        {
            var result = false;

            try
            {
                act();

                result = true;
            }
            catch { }

            return result;
        }
        public static bool Try(Action act, out Exception e)
        {
            var result = false;

            try
            {
                act();

                e = null;

                result = true;
            }
            catch (Exception ex)
            {
                e = ex;
            }

            return result;
        }

        public static TResult Try<TResult>(Func<TResult> fn, TResult errorValue = default)
        {
            TResult result;

            try
            {
                result = fn();
            }
            catch
            {
                result = errorValue;
            }

            return result;
        }
        public static TResult Try<TResult>(Func<TResult> fn, out Exception e, TResult errorValue = default)
        {
            TResult result;

            try
            {
                result = fn();
                e = null;
            }
            catch (Exception ex)
            {
                result = errorValue;
                e = ex;
            }

            return result;
        }
        public static bool Try<TResult>(Func<TResult> fn, out TResult result, out Exception ex)
        {
            var success = false;

            result = default;
            ex = null;

            try
            {
                result = fn();
                success = true;
            }
            catch (Exception e)
            {
                ex = e;
            }

            return success;
        }
    }
}
