using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Custom
{
	[Serializable]
	[DataContract]
    public sealed class SKeyValuePair<TKey, TValue> : ISerializable
    {
		[DataMember]
        public TKey Key { get; set; }

		[DataMember]
        public TValue Value { get; set; }

	    public SKeyValuePair(TKey key, TValue value)
	    {
            Key = key;
            Value = value;
        }

	    internal SKeyValuePair(SerializationInfo info, StreamingContext context)
	    {
		    if (info == null) throw new ArgumentNullException("info");

			Key = (TKey)info.GetValue("Key", typeof(TKey));
			Value = (TValue)info.GetValue("Value", typeof(TValue));
	    }

	    public void GetObjectData(SerializationInfo info, StreamingContext context)
	    {
		    info.AddValue("Key", Key);
			info.AddValue("Value", Value);
	    }

	    public static implicit operator KeyValuePair<TKey, TValue>(SKeyValuePair<TKey, TValue> o)
	    {
		    return new KeyValuePair<TKey, TValue>(o.Key, o.Value);
	    }

		public static implicit operator SKeyValuePair<TKey, TValue>(KeyValuePair<TKey, TValue> o)
		{
			return new SKeyValuePair<TKey, TValue>(o.Key, o.Value);
		}
	}
}
