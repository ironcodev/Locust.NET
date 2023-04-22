using System;
using System.Collections.Generic;

namespace Locust.Base
{
    public class DotNetTypeList : SortedSet<DotNetType>, IComparable<DotNetTypeList>, IComparable
    {
        public DotNetTypeList()
        { }
        public DotNetTypeList(params Type[] DotNetTypeList)
        {
            if (DotNetTypeList?.Length > 0)
            {
                foreach (var type in DotNetTypeList)
                {
                    Add(new DotNetType(type));
                }
            }
        }
        public DotNetTypeList(params DotNetType[] DotNetTypeList)
        {
            if (DotNetTypeList?.Length > 0)
            {
                foreach (var type in DotNetTypeList)
                {
                    Add(type);
                }
            }
        }
        public int CompareTo(DotNetTypeList other)
        {
            if (other is null)
                return 1;

            foreach (var item in other)
            {
                if (!this.Contains(item))
                {
                    return -1;
                }
            }

            return 0;
        }
        public int CompareTo(object obj)
        {
            if (obj is null)
                return 1;

            var other = obj as DotNetTypeList;

            if (other is null)
            {
                if (this.GetHashCode() > obj.GetHashCode())
                    return 1;
                else
                    return -1;
            }

            return CompareTo(other);
        }
        public override bool Equals(object obj)
        {
            return CompareTo(obj) == 0;
        }
        public static bool operator ==(DotNetTypeList t1, DotNetTypeList t2)
        {
            if (t1 is null)
            {
                if (t2 is null)
                {
                    return true;
                }
                else
                {
                    return t2.Count == 0;
                }
            }
            else
            {
                if (t2 is null)
                {
                    return t1.Count == 0;
                }
                else
                {
                    return t1.Equals(t2);
                }
            }
        }
        public static bool operator !=(DotNetTypeList t1, DotNetTypeList t2) => !(t1 == t2);
    }
}
