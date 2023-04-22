using System;

namespace Locust.Base
{
    public class DefaultAnyComparer : IAnyComparer
    {
        public int Compare(object x, object y)
        {
            int? result = null;

            do
            {
                if (x == null)
                {
                    if (y == null)
                    {
                        result = 0;
                        break;
                    }

                    result = -1;
                    break;
                }

                if (y == null)
                {
                    result = 1;
                    break;
                }

                var xc = x as IComparable;

                if (xc != null)
                {
                    try
                    {
                        result = xc.CompareTo(y);
                    }
                    catch
                    {
                        if (y is IConvertible)
                        {
                            result = xc.CompareTo(System.Convert.ChangeType(y, x.GetType()));
                        }
                    }

                    break;
                }

                var yc = y as IComparable;

                if (yc != null)
                {
                    try
                    {
                        result = yc.CompareTo(x);
                    }
                    catch
                    {
                        if (x is IConvertible)
                        {
                            result = yc.CompareTo(System.Convert.ChangeType(x, y.GetType()));
                        }
                    }

                    break;
                }

            } while (false);

            if (result == null)
            {
                result = x.Equals(y) ? 0 : x.GetHashCode().CompareTo(y.GetHashCode());
            }

            return result.Value;
        }
    }
}
