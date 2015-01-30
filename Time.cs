using System;
using System.Runtime.Serialization;

namespace CustomControls
{
    public struct Time : IComparable, IFormattable, IConvertible, ISerializable, IComparable<Time>, IEquatable<Time>
    {
        #region VARIABLES

        private uint _ticks;

        #endregion

        public static readonly Time MinValue = new Time();

        public static readonly Time MaxValue = new Time();

        #region CONSTRUCTORS

        static Time(){}

        public Time(int ticks)
        {
            _ticks = (uint) ticks;
        }

        private Time(uint timeData)
        {
            _ticks = timeData;
        }

        public Time(int ticks, TimeKind kind)
        {
            throw new NotImplementedException();
        }

        internal Time(int ticks, TimeKind kind, bool isAmbiguousDst)
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
            var t2 = new Time
            {
                _ticks = (uint) (t._ticks + ts.Ticks)
            };

            if (t2 > MaxValue) t2._ticks -= MaxValue._ticks;

            return t2;
        }

        public static Time operator -(Time t, TimeSpan ts)
        {
            Time t2;

            if (t._ticks < ts.Ticks)
            {
                var remTicks = ts.Ticks%MaxValue._ticks;
                t2 = new Time
                {
                    _ticks = (uint)(MaxValue._ticks - remTicks)
                };
            }
            else
            {
                t2 = new Time
                {
                    _ticks = (uint)(MaxValue._ticks - ts.Ticks)
                };
            }
            
            return t2;
        }

        public static TimeSpan operator -(Time t1, Time t2)
        {
            return new TimeSpan(Math.Abs(t1._ticks - t2._ticks));
        }

        public static bool operator ==(Time t1, Time t2)
        {
            return t1._ticks == t2._ticks;
        }

        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <(Time t1, Time t2)
        {
            return t1._ticks < t2._ticks;
        }

        public static bool operator <=(Time t1, Time t2)
        {
            return t1._ticks <= t2._ticks;
        }

        public static bool operator >(Time t1, Time t2)
        {
            return t1._ticks > t2._ticks;
        }

        public static bool operator >=(Time t1, Time t2)
        {
            return t1._ticks >= t2._ticks;
        }

        #endregion

        #region METHODS

        public Time Add(TimeSpan value)
        {
            return this + value;
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
