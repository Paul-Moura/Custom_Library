using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Custom
{
	//[Serializable]
	//public class SDictionary<TKey, TValue> : IDictionary<TKey, TValue>
	//{
	//    private readonly List<SKeyValuePair<TKey, TValue>> _list = new List<SKeyValuePair<TKey, TValue>>();

	//    public TValue this[TKey key]
	//    {
	//        get
	//        {
	//            SKeyValuePair<TKey, TValue> kvp = _list.FirstOrDefault(pair => pair.Key.Equals(key));
	//            return kvp.Value;
	//        }
	//        set
	//        {
	//            SKeyValuePair<TKey, TValue> kvp = _list.FirstOrDefault(pair => pair.Key.Equals(key));
	//            kvp.Value = value;
	//        }
	//    }

	//    public SKeyValuePair<TKey, TValue> this[int index]
	//    {
	//        get
	//        {
	//            return _list[index];
	//        }
	//    }

	//    public bool ContainsKey(TKey key)
	//    {
	//        return _list.Any(x => x.Equals(key));
	//    }
	//}

	[Serializable]
	[DataContract]
	public class SDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ISerializable, IXmlSerializable
	{
		[DataMember]
		private List<SKeyValuePair<TKey, TValue>> _items;

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return _items.Select(pair => (KeyValuePair<TKey, TValue>) pair).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(KeyValuePair<TKey, TValue> item)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			throw new NotImplementedException();
		}

		public int Count { get { return _items.Count; } }

		public bool IsReadOnly { get; private set; }

		public bool ContainsKey(TKey key)
		{
			return _items.Any(x => x.Key.Equals(key));
		}

		public void Add(TKey key, TValue value)
		{
			if (ReferenceEquals(key, null)) throw new ArgumentNullException();
			if (_items.Any(x => x.Key.Equals(key)))
			{
				throw new ArgumentException();
			}
			_items.Add(new SKeyValuePair<TKey, TValue>(key, value));
		}

		public bool Remove(TKey key)
		{
			return _items.RemoveAll(x => x.Key.Equals(key)) > 0;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			foreach (var pair in _items.Where(pair => pair.Key.Equals(key)))
			{
				value = pair.Value;
				return true;
			}

			value = default(TValue);
			return false;
		}

		public TValue this[TKey key]
		{
			get
			{
				SKeyValuePair<TKey, TValue> kvp = _items.FirstOrDefault(pair => pair.Key.Equals(key));
				if (kvp == null) throw new KeyNotFoundException("The given key was not present in the dictionary.");
				return kvp.Value;
			}
			set
			{
				var kvp = _items.FirstOrDefault(pair => pair.Key.Equals(key));

				if (kvp != null)
				{
					kvp.Value = value;
				}
				else
				{
					_items.Add(new SKeyValuePair<TKey, TValue>(key, value));
				}
			}
		}

		public ICollection<TKey> Keys
		{
			get
			{
				ICollection<TKey> collection = new Collection<TKey>();
				foreach (var pair in _items)
				{
					collection.Add(pair.Key);
				}
				return collection;
			}
		}

		public ICollection<TValue> Values
		{
			get
			{
				ICollection<TValue> collection = new Collection<TValue>();
				foreach (var pair in _items)
				{
					collection.Add(pair.Value);
				}
				return collection;
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Items", _items);
		}

		public SDictionary()
		{
			_items = new List<SKeyValuePair<TKey, TValue>>();
		}

		public SDictionary(SerializationInfo info, StreamingContext context)
		{
			_items = (List<SKeyValuePair<TKey, TValue>>) info.GetValue("Items", typeof (List<SKeyValuePair<TKey, TValue>>));
		}

		public System.Xml.Schema.XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(System.Xml.XmlReader reader)
		{
			XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
			XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

			bool wasEmpty = reader.IsEmptyElement;
			reader.Read();

			if (wasEmpty) return;

			while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
			{
				reader.ReadStartElement("item");

				reader.ReadStartElement("key");
				TKey key = (TKey)keySerializer.Deserialize(reader);
				reader.ReadEndElement();

				reader.ReadStartElement("value");
				TValue value = (TValue)valueSerializer.Deserialize(reader);
				reader.ReadEndElement();

				this.Add(key, value);

				reader.ReadEndElement();
				reader.MoveToContent();
			}
			reader.ReadEndElement();

		}

		public void WriteXml(System.Xml.XmlWriter writer)
		{
			XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
			XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

			foreach (TKey key in this.Keys)
			{
				writer.WriteStartElement("item");

				writer.WriteStartElement("key");
				keySerializer.Serialize(writer, key);
				writer.WriteEndElement();

				writer.WriteStartElement("value");
				TValue value = this[key];
				valueSerializer.Serialize(writer, value);
				writer.WriteEndElement();

				writer.WriteEndElement();
			}

		}
	}
}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;
//using System.Xml;
//using System.Xml.Serialization;

//namespace System_Data
//{
//    /// <summary>
//    /// Represents a collection of keys and values.
//    /// </summary>
//    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
//    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
//    [Serializable]
//    public class SDictionary<TKey, TValue>
//    {
//        private readonly List<TKey> _keys = new List<TKey>();
//        private readonly List<TValue> _values = new List<TValue>();

//        /// <summary>
//        /// Gets or sets the value associated with the specified key.
//        /// </summary>
//        /// <param name="key">The key of the value to get or set.</param>
//        /// <returns>The value associated with the specified key. If the specified key is not found, a get operation throws a <see cref="T:System.Collections.Generic.KeyNotFoundException"/>, and a set operation creates a new element with the specified key.</returns>
//        /// <exception cref="T:System.ArgumentNullException"><paramref name="key"/> is null.</exception>
//        /// <exception cref="T:System.Collections.Generic.KeyNotFoundException">The property is retrieved and <paramref name="key"/> does not exist in the collection.</exception>
//        public TValue this[TKey key]
//        {
//            get
//            {
//                if (key.Equals(null)) throw new ArgumentNullException();

//                var i = _keys.FindIndex(x => x.Equals(key));

//                if (i < 0) throw new KeyNotFoundException("An element with Key = \"" + key + "\" does not exist.");

//                return _values[i];
//            }
//            set
//            {
//                if (key.Equals(null)) throw new ArgumentNullException();

//                var i = _keys.FindIndex(x => x.Equals(key));

//                if (i < 0) throw new KeyNotFoundException("An element with Key = \"" + key + "\" does not exist.");

//                _values[i] = value;
//            }
//        }

//        /// <summary>
//        /// Gets the number of key/value pairs contained in the <see cref="T:System_Data.SDictionary`2"/>.
//        /// </summary>
//        /// 
//        /// <returns>
//        /// The number of key/value pairs contained in the <see cref="T:System_Data.SDictionary`2"/>.
//        /// </returns>
//        public int Count
//        {
//            get { return _keys.Count; }
//        }


//        /// <summary>
//        /// Adds the specified key and value to the dictionary.
//        /// </summary>
//        /// <param name="key">The key of the element to add.</param>
//        /// <param name="value">The value of the element to add. The value can be null for reference types.</param>
//        /// <exception cref="T:System.ArgumentNullException"><paramref name="key"/> is null.</exception>
//        /// <exception cref="T:System.ArgumentException">An element with the same key already exists in the <see cref="T:System_Data.SDictionary`2"/>.</exception>
//        public void Add(TKey key, TValue value)
//        {
//            if (key.Equals(null)) throw new ArgumentNullException();
//            if (_keys.Contains(key)) throw new ArgumentException("An element with Key = \"" + key + "\" already exists.");

//            _keys.Add(key);
//            _values.Add(value);
//        }

//        /// <summary>
//        /// Removes the value with the specified key from the <see cref="T:System_Data.SDictionary`2"/>.
//        /// </summary>
//        /// 
//        /// <returns>
//        /// true if the element is successfully found and removed; otherwise, false.  This method returns false if <paramref name="key"/> is not found in the <see cref="T:System_Data.SDictionary`2"/>.
//        /// </returns>
//        /// <param name="key">The key of the element to remove.</param>
//        /// <exception cref="T:System.ArgumentNullException"><paramref name="key"/> is null.</exception>
//        public bool Remove(Predicate<TKey> key)
//        {
//            if (key.Equals(null)) throw new ArgumentNullException();

//            var i = _keys.FindIndex(key);

//            if (i < 0) return false;

//            _keys.RemoveAt(i);
//            _values.RemoveAt(i);

//            return true;
//        }

//        /// <summary>
//        /// Determines whether the <see cref="T:System_Data.SDictionary`2"/> contains the specified key.
//        /// </summary>
//        /// 
//        /// <returns>
//        /// true if the <see cref="T:System_Data.SDictionary`2"/> contains an element with the specified key; otherwise, false.
//        /// </returns>
//        /// <param name="key">The key to locate in the <see cref="T:System_Data.SDictionary`2"/>.</param>
//        /// <exception cref="T:System.ArgumentNullException"><paramref name="key"/> is null.</exception>
//        public bool ContainsKey(TKey key)
//        {
//            if (key.Equals(null)) throw new ArgumentNullException();

//            return _keys.Contains(key);
//        }

//        /// <summary>
//        /// Determines whether the <see cref="T:System_Data.SDictionary`2"/> contains a specific value.
//        /// </summary>
//        /// 
//        /// <returns>
//        /// true if the <see cref="T:System_Data.SDictionary`2"/> contains an element with the specified value; otherwise, false.
//        /// </returns>
//        /// <param name="value">The value to locate in the <see cref="T:System_Data.SDictionary`2"/>. The value can be null for reference types.</param>
//        public bool ContainsValue(TValue value)
//        {
//            return _values.Contains(value);
//        }

//        /// <summary>
//        /// Gets a collection containing the keys in the <see cref="T:System_Data.SDictionary`2"/>.
//        /// </summary>
//        /// 
//        /// <returns>
//        /// A <see cref="T:System.Collections.Generic.List`1"/> containing the keys in the <see cref="T:System_Data.SDictionary`2"/>.
//        /// </returns>
//        public List<TKey> Keys
//        {
//            get { return _keys; }
//        }

//        /// <summary>
//        /// Gets a collection containing the values in the <see cref="T:System_Data.SDictionary`2"/>.
//        /// </summary>
//        /// 
//        /// <returns>
//        /// A <see cref="T:System.Collections.Generic.List`1"/> containing the values in the <see cref="T:System_Data.SDictionary`2"/>.
//        /// </returns>
//        public List<TValue> Values
//        {
//            get { return _values; }
//        }

//        /// <summary>
//        /// Instantiates a new <see cref="T:System_Data.SDictionary`2"/> containing a copy of the existsing keys and paired values.
//        /// </summary>
//        /// <returns>A <see cref="T:System_Data.SDictionary`2"/> containing a copy of the existsing keys and paired values.</returns>
//        public SDictionary<TKey, TValue> Copy()
//        {
//            var newDictionary = new SDictionary<TKey, TValue>();
//            for (int i = 0; i < _keys.Count; i++)
//            {
//                var key = _keys[i];
//                var value = _values[i];
//                newDictionary.Add(key, value);
//            }
//            return newDictionary;
//        }

//        /// <summary>
//        /// Serializes this <see cref="T:System_Data.SDictionary`2"/> using <see cref="T:System.Xml.Serialization.XmlSerializer"/> into a <see cref="T:System.Text.StringBuilder"/>.
//        /// </summary>
//        /// <returns>A string of XML Serialized data from the <see cref="T:System.Text.StringBuilder"/>.</returns>
//        public string Serialize()
//        {
//            var builder = new StringBuilder();

//            new XmlSerializer(typeof(SDictionary<TKey, TValue>)).Serialize(XmlWriter.Create(builder), this);

//            return builder.ToString();
//        }

//        /// <summary>
//        /// Deseralizes a string of XML Serialized data from a <see cref="T:System.Text.StringBuilder"/> to a <see cref="T:System_Data.SDictionary`2"/>.
//        /// </summary>
//        /// <param name="serializedData">A string of XML Serialized data from a <see cref="T:System.Text.StringBuilder"/></param>
//        /// <returns>A <see cref="T:System_Data.SDictionary`2"/>.</returns>
//        public static SDictionary<TKey, TValue> Deserialize(string serializedData)
//        {
//            return new XmlSerializer(typeof(SDictionary<TKey, TValue>)).Deserialize(new StringReader(serializedData)) as SDictionary<TKey, TValue>;
//        }
//    }
//}
