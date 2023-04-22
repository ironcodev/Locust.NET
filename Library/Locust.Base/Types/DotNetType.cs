using System;

namespace Locust.Base
{
    public class DotNetType : IComparable<DotNetType>, IComparable
    {
        public Type Value { get; private set; }
        public DotNetType(Type type)
        {
            Value = type;
        }
        public int CompareTo(DotNetType other)
        {
            if (other is null)
                return 1;

            if (this.Equals(other))
                return 0;

            return -1;
        }
        public int CompareTo(object obj)
        {
            if (obj is null)
                return 1;

            if (this.Equals(obj))
                return 0;

            return -1;
        }
        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;

            var type = obj as Type;

            if (!(type is null))
                return Value == type;

            var dntype = obj as DotNetType;

            if (!(dntype is null))
                return Value == dntype.Value;

            return false;
        }
        public static bool operator ==(DotNetType t1, DotNetType t2)
        {
            if (t1 is null)
            {
                if (t2 is null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (t2 is null)
                {
                    return false;
                }
                else
                {
                    return t1.Equals(t2);
                }
            }
        }
        public static bool operator !=(DotNetType t1, DotNetType t2) => !(t1 == t2);
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        public override string ToString()
        {
            return Value.ToString();
        }
        public static implicit operator DotNetType(Type type)
        {
            return new DotNetType(type);
        }
    }
    public class DotNetType<T>: DotNetType
    {
        public DotNetType(): base(typeof(T))
        { }
    }
}
