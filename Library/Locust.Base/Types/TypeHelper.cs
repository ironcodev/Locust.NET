using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading;

namespace Locust.Base
{
    public static partial class TypeHelper
    {
        #region Type Properties
        public static Type TypeOfInt16 { get; private set; }
        public static Type TypeOfShort { get { return TypeOfInt16; } }
        public static Type TypeOfInt32 { get; private set; }
        public static Type TypeOfInt { get { return TypeOfInt32; } }
        public static Type TypeOfInt64 { get; private set; }
        public static Type TypeOfLong { get { return TypeOfInt64; } }
        public static Type TypeOfUInt16 { get; private set; }
        public static Type TypeOfUShort { get { return TypeOfUInt16; } }
        public static Type TypeOfUInt32 { get; private set; }
        public static Type TypeOfUInt { get { return TypeOfUInt32; } }
        public static Type TypeOfUInt64 { get; private set; }
        public static Type TypeOfULong { get { return TypeOfUInt64; } }
        public static Type TypeOfSingle { get; private set; }
        public static Type TypeOfFloat { get { return TypeOfSingle; } }
        public static Type TypeOfDouble { get; private set; }
        public static Type TypeOfDecimal { get; private set; }
        public static Type TypeOfByte { get; private set; }
        public static Type TypeOfSByte { get; private set; }
        public static Type TypeOfChar { get; private set; }
        public static Type TypeOfString { get; private set; }
        public static Type TypeOfBool { get; private set; }
        public static Type TypeOfGuid { get; private set; }
        public static Type TypeOfDateTime { get; private set; }
        public static Type TypeOfDateTimeOffset { get; private set; }
        public static Type TypeOfTimeSpan { get; private set; }
        public static Type TypeOfByteArray { get; private set; }
        public static Type TypeOfCharArray { get; private set; }
        public static Type TypeOfNullable { get; private set; }
        public static Type TypeOfObject { get; private set; }
        public static Type TypeOfIGenericList { get; private set; }
        public static Type TypeOfGenericList { get; private set; }
        public static Type TypeOfIGenericDictionary { get; private set; }
        public static Type TypeOfGenericDictionary { get; private set; }
        public static Type TypeOfIEnumerableOfT { get; private set; }
        public static Type TypeOfIEnumerable { get; private set; }
        public static Type TypeOfException { get; private set; }

        public static Type TypeOfNullableInt16 { get; private set; }
        public static Type TypeOfNullableShort { get { return TypeOfNullableInt16; } }
        public static Type TypeOfNullableInt32 { get; private set; }
        public static Type TypeOfNullableInt { get { return TypeOfNullableInt32; } }
        public static Type TypeOfNullableInt64 { get; private set; }
        public static Type TypeOfNullableLong { get { return TypeOfNullableInt64; } }
        public static Type TypeOfNullableUInt16 { get; private set; }
        public static Type TypeOfNullableUShort { get { return TypeOfNullableUInt16; } }
        public static Type TypeOfNullableUInt32 { get; private set; }
        public static Type TypeOfNullableUInt { get { return TypeOfNullableUInt32; } }
        public static Type TypeOfNullableUInt64 { get; private set; }
        public static Type TypeOfNullableULong { get { return TypeOfNullableUInt64; } }
        public static Type TypeOfNullableSingle { get; private set; }
        public static Type TypeOfNullableFloat { get { return TypeOfNullableSingle; } }
        public static Type TypeOfNullableDouble { get; private set; }
        public static Type TypeOfNullableDecimal { get; private set; }
        public static Type TypeOfNullableByte { get; private set; }
        public static Type TypeOfNullableChar { get; private set; }
        public static Type TypeOfNullableSByte { get; private set; }
        public static Type TypeOfNullableBool { get; private set; }
        public static Type TypeOfNullableBigInteger { get; private set; }
        public static Type TypeOfNullableDateTime { get; private set; }
        public static Type TypeOfNullableDateTimeOffset { get; private set; }
        public static Type TypeOfNullableTimeSpan { get; private set; }
        public static Type TypeOfNullableGuid { get; private set; }

        public static Type TypeOfSqlBinary { get; private set; }
        public static Type TypeOfSqlBoolean { get; private set; }
        public static Type TypeOfSqlByte { get; private set; }
        public static Type TypeOfSqlBytes { get; private set; }
        public static Type TypeOfSqlChars { get; private set; }
        public static Type TypeOfSqlDateTime { get; private set; }
        public static Type TypeOfSqlDecimal { get; private set; }
        public static Type TypeOfSqlDouble { get; private set; }
        public static Type TypeOfSqlGuid { get; private set; }
        public static Type TypeOfSqlInt16 { get; private set; }
        public static Type TypeOfSqlInt32 { get; private set; }
        public static Type TypeOfSqlInt64 { get; private set; }
        public static Type TypeOfSqlMoney { get; private set; }
        public static Type TypeOfSqlSingle { get; private set; }
        public static Type TypeOfSqlString { get; private set; }
        public static Type TypeOfSqlXml { get; private set; }
        #endregion
        static TypeHelper()
        {
            #region initialize Type Properties
            TypeOfInt16 = typeof(System.Int16);
            TypeOfInt32 = typeof(System.Int32);
            TypeOfInt64 = typeof(System.Int64);
            TypeOfUInt16 = typeof(System.UInt16);
            TypeOfUInt32 = typeof(System.UInt32);
            TypeOfUInt64 = typeof(System.UInt64);

            TypeOfSingle = typeof(System.Single);
            TypeOfDouble = typeof(System.Double);
            TypeOfDecimal = typeof(System.Decimal);
            TypeOfByte = typeof(System.Byte);
            TypeOfSByte = typeof(System.SByte);
            TypeOfBool = typeof(System.Boolean);
            TypeOfChar = typeof(System.Char);
            TypeOfString = typeof(System.String);
            TypeOfGuid = typeof(System.Guid);
            TypeOfNullableGuid = typeof(System.Guid?);
            TypeOfDateTime = typeof(System.DateTime);
            TypeOfDateTimeOffset = typeof(System.DateTimeOffset);
            TypeOfTimeSpan = typeof(System.TimeSpan);
            TypeOfByteArray = typeof(System.Byte[]);
            TypeOfCharArray = typeof(System.Char[]);
            TypeOfNullable = typeof(System.Nullable<>);
            TypeOfObject = typeof(object);
            TypeOfIGenericList = typeof(System.Collections.Generic.IList<>);
            TypeOfGenericList = typeof(System.Collections.Generic.List<>);
            TypeOfIGenericDictionary = typeof(System.Collections.Generic.IDictionary<,>);
            TypeOfGenericDictionary = typeof(System.Collections.Generic.Dictionary<,>);
            TypeOfIEnumerable = typeof(System.Collections.IEnumerable);
            TypeOfIEnumerableOfT = typeof(System.Collections.Generic.IEnumerable<>);
            TypeOfException = typeof(System.Exception);

            TypeOfNullableInt16 = typeof(System.Nullable<System.Int16>);
            TypeOfNullableInt32 = typeof(System.Nullable<System.Int32>);
            TypeOfNullableInt64 = typeof(System.Nullable<System.Int64>);
            TypeOfNullableUInt16 = typeof(System.Nullable<System.UInt16>);
            TypeOfNullableUInt32 = typeof(System.Nullable<System.UInt32>);
            TypeOfNullableUInt64 = typeof(System.Nullable<System.UInt64>);

            TypeOfNullableSingle = typeof(System.Nullable<System.Single>);
            TypeOfNullableDouble = typeof(System.Nullable<System.Double>);
            TypeOfNullableDecimal = typeof(System.Nullable<System.Decimal>);
            TypeOfNullableByte = typeof(System.Nullable<System.Byte>);
            TypeOfNullableSByte = typeof(System.Nullable<System.SByte>);
            TypeOfNullableBool = typeof(System.Nullable<System.Boolean>);
            TypeOfNullableChar = typeof(System.Nullable<System.Char>);
            TypeOfNullableDateTime = typeof(System.Nullable<System.DateTime>);
            TypeOfNullableDateTimeOffset = typeof(System.Nullable<System.DateTimeOffset>);
            TypeOfNullableTimeSpan = typeof(System.Nullable<System.TimeSpan>);

            TypeOfSqlBinary = typeof(SqlBinary);
            TypeOfSqlBoolean = typeof(SqlBoolean);
            TypeOfSqlByte = typeof(SqlByte);
            TypeOfSqlBytes = typeof(SqlBytes);
            TypeOfSqlChars = typeof(SqlChars);
            TypeOfSqlDateTime = typeof(SqlDateTime);
            TypeOfSqlDecimal = typeof(SqlDecimal);
            TypeOfSqlDouble = typeof(SqlDouble);
            TypeOfSqlGuid = typeof(SqlGuid);
            TypeOfSqlInt16 = typeof(SqlInt16);
            TypeOfSqlInt32 = typeof(SqlInt32);
            TypeOfSqlInt64 = typeof(SqlInt64);
            TypeOfSqlMoney = typeof(SqlMoney);
            TypeOfSqlSingle = typeof(SqlSingle);
            TypeOfSqlString = typeof(SqlString);
            TypeOfSqlXml = typeof(SqlXml);
            #endregion
        }
    }
    public static partial class TypeHelper
    {
        public static IEnumerable<T> GetValues<T>() where T : struct, IConvertible
        {
            var type = typeof(T);

            if (type.IsEnum)
                return Enum.GetValues(type).Cast<T>();
            else
                throw new ArgumentException(string.Format("{0} is not an enum", type));
        }

        public static Type FindType(string typename)
        {
            var result = Type.GetType(typename);

            if (result == null)
            {
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    result = asm.GetType(typename);

                    if (result != null)
                        break;
                }
            }

            return result;
        }
        public static object FindTypeAndActivate(string typename, params object[] args)
        {
            var type = FindType(typename);
            var result = ObjectActivator.Instance.Activate(type, args);

            return result;
        }
        public static object FindTypeAndSafeActivate(string typename, params object[] args)
        {
            var type = FindType(typename);
            var result = ObjectActivator.Instance.SafeActivate(type, args);

            return result;
        }
        public static bool FindTypeAndTryActivate(string typename, out object result, params object[] args)
        {
            var type = FindType(typename);

            return ObjectActivator.Instance.TryActivate(type, out result, args);
        }
        public static bool FindTypeAndTryActivate(string typename, out object result, out Exception exception, params object[] args)
        {
            var type = FindType(typename);

            return ObjectActivator.Instance.TryActivate(type, out result, out exception, args);
        }

        public static TAbstraction EnsureInitialized<TAbstraction, TConcretion>(ref TAbstraction value, bool threadSafe = false)
            where TConcretion : TAbstraction, new()
        {
            if (value == null)
            {
                if (threadSafe)
                    Monitor.Enter(AppDomain.CurrentDomain);

                value = new TConcretion();

                if (threadSafe)
                    Monitor.Exit(AppDomain.CurrentDomain);
            }

            return value;
        }
        public static TAbstraction EnsureInitialized<TAbstraction>(ref TAbstraction value, Func<TAbstraction> fnCreate, bool threadSafe = false)
        {
            if (value == null)
            {
                if (threadSafe)
                    Monitor.Enter(AppDomain.CurrentDomain);

                value = fnCreate();

                if (threadSafe)
                    Monitor.Exit(AppDomain.CurrentDomain);
            }

            return value;
        }
    }
}
