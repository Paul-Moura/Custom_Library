using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Custom
{
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
			var keySerializer = new XmlSerializer(typeof(TKey));
			var valueSerializer = new XmlSerializer(typeof(TValue));

			bool wasEmpty = reader.IsEmptyElement;
			reader.Read();

			if (wasEmpty) return;

			while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
			{
				reader.ReadStartElement("item");

				reader.ReadStartElement("key");
				var key = (TKey)keySerializer.Deserialize(reader);
				reader.ReadEndElement();

				reader.ReadStartElement("value");
				var value = (TValue)valueSerializer.Deserialize(reader);
				reader.ReadEndElement();

				Add(key, value);

				reader.ReadEndElement();
				reader.MoveToContent();
			}
			reader.ReadEndElement();
		}

		public void WriteXml(System.Xml.XmlWriter writer)
		{
			var keySerializer = new XmlSerializer(typeof(TKey));
			var valueSerializer = new XmlSerializer(typeof(TValue));

			foreach (TKey key in Keys)
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
