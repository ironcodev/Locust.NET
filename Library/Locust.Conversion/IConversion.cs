using System;

namespace Locust.Conversion
{
    public interface IConversion
    {
        double Deg2Rad(double degrees);
        double Rad2Deg(double radians);
        bool ToBoolean(object x, bool @default = false);
        bool? ToBooleanNullable(object x, bool? @default = null);
        byte ToByte(object x, byte @default = 0);
        byte? ToByteNullable(object x, byte? @default = null);
        char ToChar(object x, char @default = '\0');
        char? ToCharNullable(object x, char? @default = null);
        DateTime ToDateTime(object x, DateTime @default = default);
        DateTime? ToDateTimeNullable(object x, DateTime? @default = null);
        decimal ToDecimal(object x, decimal @default = 0);
        decimal? ToDecimalNullable(object x, decimal? @default = null);
        double ToDouble(object x, double @default = 0);
        double? ToDoubleNullable(object x, double? @default = null);
        Guid ToGuid(object x, Guid @default = default);
        Guid? ToGuidNullable(object x, Guid? @default = null);
        int ToInt(object x, int @default = 0);
        short ToInt16(object x, short @default = 0);
        short? ToInt16Nullable(object x, short? @default = null);
        int ToInt32(object x, int @default = 0);
        int? ToInt32Nullable(object x, int? @default = null);
        long ToInt64(object x, long @default = 0);
        long? ToInt64Nullable(object x, long? @default = null);
        int? ToIntNullable(object x, int? @default = null);
        long ToLong(object x, long @default = 0);
        long? ToLongNullable(object x, long? @default = null);
        sbyte ToSByte(object x, sbyte @default = 0);
        sbyte? ToSByteNullable(object x, sbyte? @default = null);
        short ToShort(object x, short @default = 0);
        short? ToShortNullable(object x, short? @default = null);
        float ToSingle(object x, float @default = 0);
        float? ToSingleNullable(object x, float? @default = null);
        string ToString(object x, string @default = null);
        uint ToUInt(object x, uint @default = 0);
        ushort ToUInt16(object x, ushort @default = 0);
        ushort? ToUInt16Nullable(object x, ushort? @default = null);
        uint ToUInt32(object x, uint @default = 0);
        uint? ToUInt32Nullable(object x, uint? @default = null);
        ulong ToUInt64(object x, ulong @default = 0);
        ulong? ToUInt64Nullable(object x, ulong? @default = null);
        uint? ToUIntNullable(object x, uint? @default = null);
        ulong ToULong(object x, ulong @default = 0);
        ulong? ToULongNullable(object x, ulong? @default = null);
        ushort ToUShort(object x, ushort @default = 0);
        ushort? ToUShortNullable(object x, ushort? @default = null);
        object Convert(object value, Type target, object @default = default);
        object ToEnum(object value, Type type, bool ignoreCase = true, bool autoDefault = true);
    }
}