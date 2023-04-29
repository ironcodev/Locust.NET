using System;
using System.Data.SqlTypes;
using Locust.Base;

namespace Locust.Conversion
{
    public class SafeConvert : IConversion
    {
        bool IsValid(object x, bool assumeAllWhitespaceAsValid = false)
        {
            var s = x?.ToString();

            if (x == null || DBNull.Value.Equals(x))
                return false;

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
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Int64)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Int64)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Int64)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Int64)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Int64)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Int64)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Int64)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Int64)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Int64.Parse(((SqlString)x).Value);
                            break;
                        }
                        result = System.Convert.ToInt64(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Int32 ToInt32(object x, Int32 @default = default)
        {
            int result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Int32)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Int32)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Int32)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Int32)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Int32)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Int32)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Int32)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Int32)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Int32.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToInt32(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Int16 ToInt16(object x, Int16 @default = default)
        {
            Int16 result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Int16)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Int16)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Int16)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Int16)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Int16)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Int16)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Int16)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Int16)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Int16.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToInt16(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Decimal ToDecimal(object x, Decimal @default = default)
        {
            decimal result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Decimal)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Decimal)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Decimal)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Decimal)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Decimal)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Decimal)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Decimal)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Decimal)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Decimal.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToDecimal(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Double ToDouble(object x, Double @default = default)
        {
            double result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Double)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Double)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Double)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Double)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Double)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Double)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Double)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Double)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Double.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToDouble(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Single ToSingle(object x, Single @default = default)
        {
            Single result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Single)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Single)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Single)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Single)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Single)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Single)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Single)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Single)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Single.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToSingle(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public String ToString(object x, String @default = default)
        {
            string result = @default;

            if (IsValid(x, false))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = ((SqlInt64)x).Value.ToString();
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = ((SqlInt32)x).Value.ToString();
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = ((SqlInt16)x).Value.ToString();
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = ((SqlByte)x).Value.ToString();
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = ((SqlDecimal)x).Value.ToString();
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = ((SqlDouble)x).Value.ToString();
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = ((SqlSingle)x).Value.ToString();
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = ((SqlMoney)x).Value.ToString();
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = ((SqlString)x).Value.ToString();
                            break;
                        }
                        if (x is SqlGuid)
                        {
                            result = ((SqlGuid)x).Value.ToString();
                            break;
                        }
                        if (x is SqlBoolean)
                        {
                            result = ((SqlBoolean)x).Value.ToString();
                            break;
                        }
                        if (x is SqlDateTime)
                        {
                            result = ((SqlDateTime)x).Value.ToString();
                            break;
                        }
                        if (x is SqlBinary)
                        {
                            result = System.Text.Encoding.Unicode.GetString(((SqlBinary)x).Value);
                            break;
                        }
                        if (x is SqlBytes)
                        {
                            result = System.Text.Encoding.Unicode.GetString(((SqlBytes)x).Value);
                            break;
                        }
                        if (x is SqlChars)
                        {
                            result = new String(((SqlChars)x).Value);
                            break;
                        }
                        if (x is SqlXml)
                        {
                            result = ((SqlXml)x).Value;
                            break;
                        }

                        result = System.Convert.ToString(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Char ToChar(object x, Char @default = default)
        {
            char result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Char)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Char)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Char)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Char)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Char)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Char)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Char)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Char)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Char.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToChar(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Byte ToByte(object x, Byte @default = default)
        {
            byte result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Byte)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Byte)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Byte)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Byte)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Byte)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Byte)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Byte)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Byte)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Byte.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToByte(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public SByte ToSByte(object x, SByte @default = default)
        {
            sbyte result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (SByte)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (SByte)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (SByte)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (SByte)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (SByte)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (SByte)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (SByte)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (SByte)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = SByte.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToSByte(x);
                    }
                    catch
                    { }
                } while (false);
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
                        if (x is SqlInt64)
                        {
                            result = ((SqlInt64)x).Value != 0;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = ((SqlInt32)x).Value != 0;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = ((SqlInt16)x).Value != 0;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = ((SqlByte)x).Value != 0;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = ((SqlDecimal)x).Value != 0;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = ((SqlDouble)x).Value != 0;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = ((SqlSingle)x).Value != 0;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = ((SqlMoney)x).Value != 0;
                            break;
                        }
                        if (x is SqlString)
                        {
                            x = ((SqlString)x).Value.Trim();
                            goto string_value;
                        }
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
string_value:
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
                do
                {
                    try
                    {
                        if (x is SqlDateTime)
                        {
                            result = (DateTime)((SqlDateTime)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = DateTime.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToDateTime(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Guid ToGuid(object x, Guid @default = default)
        {
            Guid result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlGuid)
                        {
                            result = (Guid)((SqlGuid)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            Guid.TryParse(((SqlString)x).Value, out result);
                            break;
                        }

                        System.Guid.TryParse(x.ToString(), out result);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public UInt64 ToUInt64(object x, UInt64 @default = default)
        {
            UInt64 result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (UInt64)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (UInt64)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (UInt64)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (UInt64)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (UInt64)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (UInt64)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (UInt64)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (UInt64)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = UInt64.Parse(((SqlString)x).Value);
                            break;
                        }
                        result = System.Convert.ToUInt64(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public UInt32 ToUInt32(object x, UInt32 @default = default)
        {
            UInt32 result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (UInt32)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (UInt32)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (UInt32)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (UInt32)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (UInt32)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (UInt32)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (UInt32)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (UInt32)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = UInt32.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToUInt32(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public UInt16 ToUInt16(object x, UInt16 @default = default)
        {
            UInt16 result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (UInt16)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (UInt16)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (UInt16)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (UInt16)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (UInt16)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (UInt16)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (UInt16)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (UInt16)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = UInt16.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToUInt16(x);
                    }
                    catch
                    { }
                } while (false);
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
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Int64)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Int64)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Int64)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Int64)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Int64)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Int64)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Int64)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Int64)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Int64.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToInt64(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Int32? ToInt32Nullable(object x, Int32? @default = default)
        {
            Int32? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Int32)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Int32)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Int32)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Int32)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Int32)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Int32)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Int32)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Int32)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Int32.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToInt32(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Int16? ToInt16Nullable(object x, Int16? @default = default)
        {
            Int16? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Int16)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Int16)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Int16)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Int16)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Int16)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Int16)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Int16)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Int16)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Int16.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToInt16(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Decimal? ToDecimalNullable(object x, Decimal? @default = default)
        {
            Decimal? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Decimal)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Decimal)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Decimal)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Decimal)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Decimal)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Decimal)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Decimal)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Decimal)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Decimal.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToDecimal(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Double? ToDoubleNullable(object x, Double? @default = default)
        {
            Double? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Double)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Double)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Double)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Double)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Double)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Double)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Double)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Double)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Double.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToDouble(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Single? ToSingleNullable(object x, Single? @default = default)
        {
            Single? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Single)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Single)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Single)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Single)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Single)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Single)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Single)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Single)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Single.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToSingle(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Char? ToCharNullable(object x, Char? @default = default)
        {
            Char? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Char)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Char)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Char)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Char)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Char)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Char)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Char)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Char)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Char.Parse(((SqlString)x).Value);
                            break;
                        }
                        result = System.Convert.ToChar(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Byte? ToByteNullable(object x, Byte? @default = default)
        {
            Byte? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (Byte)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (Byte)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (Byte)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (Byte)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (Byte)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (Byte)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (Byte)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (Byte)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = Byte.Parse(((SqlString)x).Value);
                            break;
                        }

                        result = System.Convert.ToByte(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public SByte? ToSByteNullable(object x, SByte? @default = default)
        {
            SByte? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (SByte)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (SByte)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (SByte)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (SByte)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (SByte)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (SByte)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (SByte)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (SByte)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = SByte.Parse(((SqlString)x).Value);
                            break;
                        }
                        result = System.Convert.ToSByte(x);
                    }
                    catch
                    { }
                } while (false);
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
                        if (x is SqlInt64)
                        {
                            result = ((SqlInt64)x).Value != 0;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = ((SqlInt32)x).Value != 0;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = ((SqlInt16)x).Value != 0;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = ((SqlByte)x).Value != 0;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = ((SqlDecimal)x).Value != 0;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = ((SqlDouble)x).Value != 0;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = ((SqlSingle)x).Value != 0;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = ((SqlMoney)x).Value != 0;
                            break;
                        }
                        if (x is SqlString)
                        {
                            x = ((SqlString)x).Value.Trim();
                            goto string_value;
                        }
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
string_value:
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
                do
                {
                    try
                    {
                        if (x is SqlDateTime)
                        {
                            result = (DateTime)((SqlDateTime)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = DateTime.Parse(((SqlString)x).Value);
                            break;
                        }
                        result = System.Convert.ToDateTime(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public Guid? ToGuidNullable(object x, Guid? @default = default)
        {
            Guid? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlGuid)
                        {
                            result = (Guid)((SqlGuid)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            Guid r;
                            if (Guid.TryParse(((SqlString)x).Value, out r))
                            {
                                result = r;
                            }
                            break;
                        }
                        Guid g;
                        if (Guid.TryParse(x.ToString(), out g))
                        {
                            result = g;
                        }
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public UInt64? ToUInt64Nullable(object x, UInt64? @default = default)
        {
            UInt64? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (UInt64)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (UInt64)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (UInt64)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (UInt64)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (UInt64)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (UInt64)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (UInt64)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (UInt64)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = UInt64.Parse(((SqlString)x).Value);
                            break;
                        }
                        result = System.Convert.ToUInt64(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public UInt32? ToUInt32Nullable(object x, UInt32? @default = default)
        {
            UInt32? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (UInt32)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (UInt32)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (UInt32)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (UInt32)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (UInt32)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (UInt32)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (UInt32)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (UInt32)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = UInt32.Parse(((SqlString)x).Value);
                            break;
                        }
                        result = System.Convert.ToUInt32(x);
                    }
                    catch
                    { }
                } while (false);
            }

            return result;
        }
        public UInt16? ToUInt16Nullable(object x, UInt16? @default = default)
        {
            UInt16? result = @default;

            if (IsValid(x))
            {
                do
                {
                    try
                    {
                        if (x is SqlInt64)
                        {
                            result = (UInt16)((SqlInt64)x).Value;
                            break;
                        }
                        if (x is SqlInt32)
                        {
                            result = (UInt16)((SqlInt32)x).Value;
                            break;
                        }
                        if (x is SqlInt16)
                        {
                            result = (UInt16)((SqlInt16)x).Value;
                            break;
                        }
                        if (x is SqlByte)
                        {
                            result = (UInt16)((SqlByte)x).Value;
                            break;
                        }
                        if (x is SqlDecimal)
                        {
                            result = (UInt16)((SqlDecimal)x).Value;
                            break;
                        }
                        if (x is SqlDouble)
                        {
                            result = (UInt16)((SqlDouble)x).Value;
                            break;
                        }
                        if (x is SqlSingle)
                        {
                            result = (UInt16)((SqlSingle)x).Value;
                            break;
                        }
                        if (x is SqlMoney)
                        {
                            result = (UInt16)((SqlMoney)x).Value;
                            break;
                        }
                        if (x is SqlString)
                        {
                            result = UInt16.Parse(((SqlString)x).Value);
                            break;
                        }
                        result = System.Convert.ToUInt16(x);
                    }
                    catch
                    { }
                } while (false);
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
    }
}
