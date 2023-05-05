using System;
using System.Data.SqlTypes;
using Locust.Base;

namespace Locust.Conversion
{
    public class SafeClrConvert : IConversion
    {
        bool IsValid(object x, bool assumeAllWhitespaceAsValid = false)
        {

            if (x == null || DBNull.Value.Equals(x))
                return false;

            var s = x?.ToString();

            if (string.IsNullOrWhiteSpace(s))
                return assumeAllWhitespaceAsValid;

            return true;
        }
        #region Non-Nullable
        public Int64 ToInt64(object x, Int64 @default = default)
        {
            Int64 result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToInt64(x);
                }
                catch
                { }
            }

            return result;
        }
        public Int32 ToInt32(object x, Int32 @default = default)
        {
            int result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToInt32(x);
                }
                catch
                { }
            }

            return result;
        }
        public Int16 ToInt16(object x, Int16 @default = default)
        {
            Int16 result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToInt16(x);
                }
                catch
                { }
            }

            return result;
        }
        public Decimal ToDecimal(object x, Decimal @default = default)
        {
            decimal result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToDecimal(x);
                }
                catch
                { }
            }

            return result;
        }
        public Double ToDouble(object x, Double @default = default)
        {
            double result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToDouble(x);
                }
                catch
                { }
            }

            return result;
        }
        public Single ToSingle(object x, Single @default = default)
        {
            Single result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToSingle(x);
                }
                catch
                { }
            }

            return result;
        }
        public String ToString(object x, String @default = "")
        {
            string result = @default;

            if (IsValid(x, false))
            {
                try
                {
                    result = System.Convert.ToString(x);
                }
                catch
                { }
            }

            return result;
        }
        public Char ToChar(object x, Char @default = default)
        {
            char result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToChar(x);
                }
                catch
                { }
            }

            return result;
        }
        public Byte ToByte(object x, Byte @default = default)
        {
            byte result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToByte(x);
                }
                catch
                { }
            }

            return result;
        }
        public SByte ToSByte(object x, SByte @default = default)
        {
            sbyte result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToSByte(x);
                }
                catch
                { }
            }

            return result;
        }
        public Boolean ToBoolean(object x, Boolean @default = default)
        {
            bool result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is Int64)
                        {
                            result = ((Int64)x) != 0;
                            break;
                        }
                        if (x is Int32)
                        {
                            result = ((Int32)x) != 0;
                            break;
                        }
                        if (x is Int16)
                        {
                            result = ((Int16)x) != 0;
                            break;
                        }
                        if (x is UInt64)
                        {
                            result = ((UInt64)x) != 0;
                            break;
                        }
                        if (x is UInt32)
                        {
                            result = ((UInt32)x) != 0;
                            break;
                        }
                        if (x is UInt16)
                        {
                            result = ((UInt16)x) != 0;
                            break;
                        }
                        if (x is Byte)
                        {
                            result = ((Byte)x) != 0;
                            break;
                        }
                        if (x is SByte)
                        {
                            result = ((SByte)x) != 0;
                            break;
                        }
                        if (x is Decimal)
                        {
                            result = ((Decimal)x) != 0;
                            break;
                        }
                        if (x is Double)
                        {
                            result = ((Double)x) != 0;
                            break;
                        }
                        if (x is Single)
                        {
                            result = ((Single)x) != 0;
                            break;
                        }
                        if (x is Char)
                        {
                            result = ((Char)x) == 'y' || ((Char)x) == 'Y';
                            break;
                        }
                        if (x is String)
                        {
                            var s = x.ToString().Trim();
                            long a;

                            if (Int64.TryParse(s, out a))
                            {
                                if (a != 0)
                                {
                                    result = true;
                                    break;
                                }
                            }
                            else
                            {
                                double d;

                                if (double.TryParse(s, out d))
                                {
                                    if (d != 0)
                                    {
                                        result = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    decimal c;

                                    if (decimal.TryParse(s, out c))
                                    {
                                        if (c != 0)
                                        {
                                            result = true;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        result = string.Compare(s, "true", false) == 0 || string.Compare(s, "True", false) == 0 || string.Compare(s, "on", true) == 0;
                                        break;
                                    }
                                }
                            }
                        }

                        result = System.Convert.ToBoolean(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public DateTime ToDateTime(object x, DateTime @default = default)
        {
            DateTime result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToDateTime(x);
                }
                catch
                { }
            }

            return result;
        }
        public Guid ToGuid(object x, Guid @default = default)
        {
            Guid result = @default;

            if (IsValid(x))
            {
                try
                {
                    System.Guid.TryParse(x.ToString(), out result);
                }
                catch
                { }
            }

            return result;
        }
        public UInt64 ToUInt64(object x, UInt64 @default = default)
        {
            UInt64 result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToUInt64(x);
                }
                catch
                { }
            }

            return result;
        }
        public UInt32 ToUInt32(object x, UInt32 @default = default)
        {
            UInt32 result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToUInt32(x);
                }
                catch
                { }
            }

            return result;
        }
        public UInt16 ToUInt16(object x, UInt16 @default = default)
        {
            UInt16 result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToUInt16(x);
                }
                catch
                { }
            }

            return result;
        }
        public UInt16 ToUShort(object x, UInt16 @default = default)
        {
            return ToUInt16(x, @default);
        }
        public UInt32 ToUInt(object x, UInt32 @default = default)
        {
            return ToUInt32(x, @default);
        }
        public UInt64 ToULong(object x, UInt64 @default = default)
        {
            return ToUInt64(x, @default);
        }
        public Int16 ToShort(object x, Int16 @default = default)
        {
            return ToInt16(x, @default);
        }
        public Int32 ToInt(object x, Int32 @default = default)
        {
            return ToInt32(x, @default);
        }
        public Int64 ToLong(object x, Int64 @default = default)
        {
            return ToInt64(x, @default);
        }
        #endregion
        #region Nullable
        public Int64? ToInt64Nullable(object x, Int64? @default = default)
        {
            Int64? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToInt64(x);
                }
                catch
                { }
            }

            return result;
        }
        public Int32? ToInt32Nullable(object x, Int32? @default = default)
        {
            Int32? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToInt32(x);
                }
                catch
                { }
            }

            return result;
        }
        public Int16? ToInt16Nullable(object x, Int16? @default = default)
        {
            Int16? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToInt16(x);
                }
                catch
                { }
            }

            return result;
        }
        public Decimal? ToDecimalNullable(object x, Decimal? @default = default)
        {
            Decimal? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToDecimal(x);
                }
                catch
                { }
            }

            return result;
        }
        public Double? ToDoubleNullable(object x, Double? @default = default)
        {
            Double? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToDouble(x);
                }
                catch
                { }
            }

            return result;
        }
        public Single? ToSingleNullable(object x, Single? @default = default)
        {
            Single? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToSingle(x);
                }
                catch
                { }
            }

            return result;
        }
        public Char? ToCharNullable(object x, Char? @default = default)
        {
            Char? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToChar(x);
                }
                catch
                { }
            }

            return result;
        }
        public Byte? ToByteNullable(object x, Byte? @default = default)
        {
            Byte? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToByte(x);
                }
                catch
                { }
            }

            return result;
        }
        public SByte? ToSByteNullable(object x, SByte? @default = default)
        {
            SByte? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToSByte(x);
                }
                catch
                { }
            }

            return result;
        }
        public Boolean? ToBooleanNullable(object x, Boolean? @default = default)
        {
            bool? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is Int64)
                        {
                            result = ((Int64)x) != 0;
                            break;
                        }
                        if (x is Int32)
                        {
                            result = ((Int32)x) != 0;
                            break;
                        }
                        if (x is Int16)
                        {
                            result = ((Int16)x) != 0;
                            break;
                        }
                        if (x is UInt64)
                        {
                            result = ((UInt64)x) != 0;
                            break;
                        }
                        if (x is UInt32)
                        {
                            result = ((UInt32)x) != 0;
                            break;
                        }
                        if (x is UInt16)
                        {
                            result = ((UInt16)x) != 0;
                            break;
                        }
                        if (x is Byte)
                        {
                            result = ((Byte)x) != 0;
                            break;
                        }
                        if (x is SByte)
                        {
                            result = ((SByte)x) != 0;
                            break;
                        }
                        if (x is Decimal)
                        {
                            result = ((Decimal)x) != 0;
                            break;
                        }
                        if (x is Double)
                        {
                            result = ((Double)x) != 0;
                            break;
                        }
                        if (x is Single)
                        {
                            result = ((Single)x) != 0;
                            break;
                        }
                        if (x is Char)
                        {
                            result = ((Char)x) == 'y' || ((Char)x) == 'Y';
                            break;
                        }
                        if (x is String)
                        {
                            var s = x.ToString().Trim();
                            int a;
                            if (Int32.TryParse(s, out a))
                            {
                                if (a != 0)
                                {
                                    result = true;
                                    break;
                                }
                            }
                            else
                            {
                                double d;

                                if (double.TryParse(s, out d))
                                {
                                    if (d != 0)
                                    {
                                        result = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    decimal c;

                                    if (decimal.TryParse(s, out c))
                                    {
                                        if (c != 0)
                                        {
                                            result = true;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        result = string.Compare(s, "true", false) == 0 || string.Compare(s, "True", false) == 0 || string.Compare(s, "on", true) == 0;
                                        break;
                                    }
                                }
                            }
                        }

                        result = System.Convert.ToBoolean(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public DateTime? ToDateTimeNullable(object x, DateTime? @default = default)
        {
            DateTime? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToDateTime(x);
                }
                catch
                { }
            }

            return result;
        }
        public Guid? ToGuidNullable(object x, Guid? @default = default)
        {
            Guid? result = @default;

            if (IsValid(x))
            {
                try
                {
                    Guid g;

                    if (Guid.TryParse(x.ToString(), out g))
                    {
                        result = g;
                    }
                }
                catch
                { }
            }

            return result;
        }
        public UInt64? ToUInt64Nullable(object x, UInt64? @default = default)
        {
            UInt64? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToUInt64(x);
                }
                catch
                { }
            }

            return result;
        }
        public UInt32? ToUInt32Nullable(object x, UInt32? @default = default)
        {
            UInt32? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToUInt32(x);
                }
                catch
                { }
            }

            return result;
        }
        public UInt16? ToUInt16Nullable(object x, UInt16? @default = default)
        {
            UInt16? result = @default;

            if (IsValid(x))
            {
                try
                {
                    result = System.Convert.ToUInt16(x);
                }
                catch
                { }
            }

            return result;
        }
        public UInt16? ToUShortNullable(object x, UInt16? @default = default)
        {
            return ToUInt16Nullable(x, @default);
        }
        public UInt32? ToUIntNullable(object x, UInt32? @default = default)
        {
            return ToUInt32Nullable(x, @default);
        }
        public UInt64? ToULongNullable(object x, UInt64? @default = default)
        {
            return ToUInt64Nullable(x, @default);
        }
        public Int16? ToShortNullable(object x, Int16? @default = default)
        {
            return ToInt16Nullable(x, @default);
        }
        public Int32? ToIntNullable(object x, Int32? @default = default)
        {
            return ToInt32Nullable(x, @default);
        }
        public Int64? ToLongNullable(object x, Int64? @default = default)
        {
            return ToInt64Nullable(x, @default);
        }
        #endregion
        public object Convert(object value, Type target, object @default = default)
        {
            var result = (object)null;

            do
            {
                if (target == TypeHelper.TypeOfBool) { result =ToBoolean(value); break; }
                if (target == TypeHelper.TypeOfNullableBool) { result =ToBooleanNullable(value); break; }
                if (target == TypeHelper.TypeOfByte) { result =ToByte(value); break; }
                if (target == TypeHelper.TypeOfNullableByte) { result =ToByteNullable(value); break; }
                if (target == TypeHelper.TypeOfChar) { result =ToChar(value); break; }
                if (target == TypeHelper.TypeOfNullableChar) { result =ToCharNullable(value); break; }
                if (target == TypeHelper.TypeOfDateTime) { result =ToDateTime(value); break; }
                if (target == TypeHelper.TypeOfNullableDateTime) { result =ToDateTimeNullable(value); break; }
                if (target == TypeHelper.TypeOfDecimal) { result =ToDecimal(value); break; }
                if (target == TypeHelper.TypeOfNullableDecimal) { result =ToDecimalNullable(value); break; }
                if (target == TypeHelper.TypeOfDouble) { result =ToDouble(value); break; }
                if (target == TypeHelper.TypeOfNullableDouble) { result =ToDoubleNullable(value); break; }
                if (target == TypeHelper.TypeOfGuid) { result =ToGuid(value); break; }
                if (target == TypeHelper.TypeOfNullableGuid) { result =ToGuidNullable(value); break; }
                if (target == TypeHelper.TypeOfInt16) { result =ToInt16(value); break; }
                if (target == TypeHelper.TypeOfNullableInt16) { result =ToInt16Nullable(value); break; }
                if (target == TypeHelper.TypeOfInt32) { result =ToInt32(value); break; }
                if (target == TypeHelper.TypeOfNullableInt32) { result =ToInt32Nullable(value); break; }
                if (target == TypeHelper.TypeOfInt64) { result =ToInt64(value); break; }
                if (target == TypeHelper.TypeOfNullableInt64) { result =ToInt64Nullable(value); break; }
                if (target == TypeHelper.TypeOfSByte) { result =ToSByte(value); break; }
                if (target == TypeHelper.TypeOfNullableSByte) { result =ToSByteNullable(value); break; }
                if (target == TypeHelper.TypeOfSingle) { result =ToSingle(value); break; }
                if (target == TypeHelper.TypeOfNullableSingle) { result =ToSingleNullable(value); break; }
                if (target == TypeHelper.TypeOfString) { result =ToString(value); break; }
                if (target == TypeHelper.TypeOfUInt16) { result =ToUInt16(value); break; }
                if (target == TypeHelper.TypeOfNullableUInt16) { result =ToUInt16Nullable(value); break; }
                if (target == TypeHelper.TypeOfUInt32) { result =ToUInt32(value); break; }
                if (target == TypeHelper.TypeOfNullableUInt32) { result =ToUInt32Nullable(value); break; }
                if (target == TypeHelper.TypeOfUInt64) { result =ToUInt64(value); break; }
                if (target == TypeHelper.TypeOfNullableUInt64) { result =ToUInt64Nullable(value); break; }

                try
                {
                    result = System.Convert.ChangeType(value, target);
                }
                catch (Exception)
                {
                    result = @default;
                }

            } while (false);

            return result;
        }
        public double Rad2Deg(double radians)
        {
            return (180 / Math.PI) * radians;
        }
        public double Deg2Rad(double degrees)
        {
            return (Math.PI / 180) * degrees;
        }
        public object ToEnum(object value, Type type, bool ignoreCase = true, bool autoDefault = true)
        {
            object result = null;

            do
            {
                if (value != null)
                {
                    var valueType = value.GetType();

                    if (valueType == type)
                    {
                        result = value;
                        break;
                    }

                    if (valueType == TypeHelper.TypeOfString)
                    {
                        var valueString = value.ToString();

                        if (!string.IsNullOrWhiteSpace(valueString))
                        {
                            try
                            {
                                result = Enum.Parse(type, valueString, ignoreCase);
                            }
                            catch
                            { }
                        }

                        break;
                    }

                    if (!(valueType.IsPrimitive
                            || valueType.IsEnum
                            || valueType == TypeHelper.TypeOfDecimal
                            ))
                    {
                        break;
                    }

                    var enumType = Enum.GetUnderlyingType(type);
                    object _value = null;

                    if (enumType == TypeHelper.TypeOfByte)
                    {
                        _value = ToByte(value);
                    }
                    else
                    if (enumType == TypeHelper.TypeOfSByte)
                    {
                        _value = ToSByte(value);
                    }
                    else
                    if (enumType == TypeHelper.TypeOfInt16)
                    {
                        _value = ToInt16(value);
                    }
                    else
                    if (enumType == TypeHelper.TypeOfUInt16)
                    {
                        _value = ToUInt16(value);
                    }
                    else
                    if (enumType == TypeHelper.TypeOfInt32)
                    {
                        _value = ToInt32(value);
                    }
                    else
                    if (enumType == TypeHelper.TypeOfUInt32)
                    {
                        _value = ToUInt32(value);
                    }
                    else
                    if (enumType == TypeHelper.TypeOfInt64)
                    {
                        _value = ToInt64(value);
                    }
                    else
                    if (enumType == TypeHelper.TypeOfUInt64)
                    {
                        _value = ToUInt64(value);
                    }

                    if (Enum.IsDefined(type, _value))
                    {
                        result = Enum.ToObject(type, value);
                    }

                    break;
                }

                if (autoDefault)
                {
                    var defaultAttribute = (DefaultAttribute)Attribute.GetCustomAttribute(type, typeof(DefaultAttribute));

                    if (defaultAttribute != null && defaultAttribute.Value != null)
                    {
                        result = ToEnum(defaultAttribute.Value, type, ignoreCase, false);
                    }
                }
            } while (false);

            if (result == null && autoDefault)
            {
                result = ObjectActivator.Instance.SafeActivate(type);
            }

            return result;
        }
    }
}
