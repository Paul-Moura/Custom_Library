using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Custom.Enums;

namespace Custom
{
	[Serializable]
    public struct Time : IComparable, IFormattable, IConvertible, ISerializable, IComparable<Time>, IEquatable<Time>
    {
        #region VARIABLES

        private ulong _ticks;

        #endregion

        public static readonly Time MinValue = new Time(0);

		public static readonly Time MaxValue = new Time(863999999999);

		public static readonly long TicksPerMillisecond = 10000;

		public static readonly long TicksPerSecond = 10000000;

		public static readonly long TicksPerMinute = 600000000;

		public static readonly long TicksPerHour = 36000000000;

        #region PROPERTIES

        public long Ticks
        {
            get { return (long) _ticks; }
        }

        #endregion

        #region CONSTRUCTORS

        static Time(){}

        public Time(long ticks)
        {
            _ticks = (ulong) ticks;
        }

		private Time(ulong timeData)
        {
            _ticks = timeData;
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
            if (info == null)
				throw new ArgumentNullException("info");

			_ticks = info.GetUInt32("Ticks");
        }

        #endregion

        #region OPERATORS

        public static Time operator +(Time t, TimeSpan ts)
        {
            var t2 = new Time
            {
				_ticks = t._ticks + (ulong)ts.Ticks
            };

            if (t2 > MaxValue) t2._ticks -= MaxValue._ticks;

            return t2;
        }

        public static Time operator -(Time t, TimeSpan ts)
        {
            Time t2;

            if (t._ticks < (decimal) ts.Ticks)
            {
                var remTicks = ts.Ticks%(decimal) MaxValue._ticks;
                t2 = new Time
                {
                    _ticks = (ulong)(MaxValue._ticks - remTicks)
                };
            }
            else
            {
                t2 = new Time
                {
					_ticks = (ulong)(MaxValue._ticks - (decimal)ts.Ticks)
                };
            }
            
            return t2;
        }

        public static TimeSpan operator -(Time t1, Time t2)
        {
            return new TimeSpan((long) Math.Abs((double) (t1._ticks - t2._ticks)));
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
			var ticks = _ticks;
			ticks += (ulong)value.Ticks;
			var t = new Time(ticks);
			return t;
        }

        public Time AddHours(double value)
        {
			var ticks = _ticks;
			ticks += (ulong)(36000000000 * value);
			var t = new Time(ticks);
			return t;
        }

        public Time AddMinutes(double value)
        {
	        var ticks = _ticks;
			ticks += (ulong)(TicksPerMinute*value);
			var t = new Time(ticks);
	        return t;
        }

        public Time AddSeconds(double value)
        {
			var ticks = _ticks;
			ticks += (ulong)(TicksPerSecond * value);
			var t = new Time(ticks);
			return t;
        }

		public Time AddMilliseconds(double value)
		{
			var ticks = _ticks;
			ticks += (ulong)(TicksPerMillisecond * value);
			var t = new Time(ticks);
			return t;
		}

        public Time AddTicks(long value)
        {
			var ticks = _ticks;
			ticks += (ulong)(value);
			var t = new Time(ticks);
			return t;
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

		public static Time Parse(string value)
		{
			if (value == null) throw new ArgumentNullException("value", "'value' is null.");
			try
			{
				var dateTime = DateTime.Parse(value);
				var ticks = dateTime.TimeOfDay.Ticks;
				var time = new Time(ticks);
				if (time > MaxValue) throw new ArgumentOutOfRangeException("value", value, "The value provided must be within the Min and Max values.");
				return time;

			}
			catch (Exception exception)
			{
				throw new FormatException("'value' does not contain a valid string representation of a time.", exception);
			}
		}

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Time && Equals((Time)obj);
        }

        public override int GetHashCode()
        {
            return (int)_ticks;
        }

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
	        var dt = new DateTime((long) _ticks);
	        return dt.ToShortTimeString();

	        //uint ticks = _ticks;
	        //string str = "";

	        //var n = (int) (ticks / (10000 * 60 * 60));
	        //ticks -= (uint)(n * 10000 * 60 * 60);
	        //str += n + ":";

	        //n = (int)(ticks / (10000 * 60));
	        //ticks -= (uint)(n * 10000 * 60);
	        //str += n + ":";

	        //n = (int)(ticks / (10000));
	        //ticks -= (uint)(n * 10000);
	        //str += n + "." + ticks;
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
	            throw new ArgumentNullException("info");

			info.AddValue("Ticks", _ticks);
        }

        public bool Equals(Time other)
        {
	        return this == other;
        }

		public static string[] GetBasicOptions()
		{
			var list = new List<string>();

			Time t = MinValue;

			while (t <= MaxValue)
			{
				var str = t.ToString(CultureInfo.InvariantCulture);
				list.Add(str);
				t = t.AddMinutes(15.0);
			}

			return list.ToArray();
		}

        #endregion
    }
}
