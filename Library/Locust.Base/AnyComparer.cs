using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locust.Base
{
    public interface IAnyComparer: IComparer { }
    public class AnyComparer : InstanceProvider<IAnyComparer, DefaultAnyComparer>
    { }
    public class DefaultAnyComparer: IAnyComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }

                return -1;
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
            }

            var xc = x as IComparable;

            if (xc != null)
            {
                try
                {
                    return xc.CompareTo(y);
                }
                catch
                {
                    return xc.CompareTo(System.Convert.ChangeType(y, x.GetType()));
                }
            }

            var yc = y as IComparable;

            if (yc != null)
            {
                try
                {
                    return yc.CompareTo(x);
                }
                catch
                {
                    return yc.CompareTo(System.Convert.ChangeType(x, y.GetType()));
                }
            }

            return x.Equals(y) ? 0 : x.GetHashCode().CompareTo(y.GetHashCode());
        }
    }
}
