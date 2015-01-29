using System;
using System.Runtime.Serialization;

namespace CustomControls
{
    public struct Time : IComparable, IFormattable, IConvertible, ISerializable, IComparable<Time>, IEquatable<Time>
    {
        public static readonly Time MinValue = new Time();

        #region CONSTRUCTORS

        static Time(){}

        public Time(long ticks)
        {
            throw new NotImplementedException();
        }

        private Time(ulong timeData)
        {
            throw new NotImplementedException();
        }

        public Time(long ticks, TimeKind kind)
        {
            throw new NotImplementedException();
        }

        internal Time(long ticks, TimeKind kind, bool isAmbiguousDst)
        {
            throw new NotImplementedException();
        }

        public Time(int hour, int minutes, int seconds)
        {
            throw new NotImplementedException();
        }

        public Time(int hour, int minutes, int seconds, TimeKind kind)
        {
            throw new NotImplementedException();
        }

        public Time(int hour, int minutes, int seconds, int miliseconds)
        {
            throw new NotImplementedException();
        }

        public Time(int hour, int minutes, int seconds, int miliseconds, TimeKind kind)
        {
            throw new NotImplementedException();
        }

        private Time(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region OPERATORS

        public static Time operator +(Time t, TimeSpan ts)
        {
            throw new NotImplementedException();
        }

        public static Time operator -(Time t, TimeSpan ts)
        {
            throw new NotImplementedException();
        }

        public static TimeSpan operator -(Time t1, Time t2)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Time t1, Time t2)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Time t1, Time t2)
        {
            throw new NotImplementedException();
        }

        public static bool operator <(Time t1, Time t2)
        {
            throw new NotImplementedException();
        }

        public static bool operator <=(Time t1, Time t2)
        {
            throw new NotImplementedException();
        }

        public static bool operator >(Time t1, Time t2)
        {
            throw new NotImplementedException();
        }

        public static bool operator >=(Time t1, Time t2)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region METHODS

        public Time Add(TimeSpan value)
        {
            throw new NotImplementedException();
        }

        private Time Add(double value, int scale)
        {
            throw new NotImplementedException();
        }

        public Time AddHours(double value)
        {
            throw new NotImplementedException();
        }

        public Time AddMinutes(double value)
        {
            throw new NotImplementedException();
        }

        public Time AddSeconds(double value)
        {
            throw new NotImplementedException();
        }

        public Time AddTicks(long value)
        {
            throw new NotImplementedException();
        }

        public static int Compare(Time t1, Time t2)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object value)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Time value)
        {
            throw new NotImplementedException();
        }

        #endregion

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Time other)
        {
            throw new NotImplementedException();
        }
    }
}
