using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom
{
    [Serializable]
    public class SDictionary<T, TU>
    {
        private readonly List<SKeyValuePair<T, TU>> _list = new List<SKeyValuePair<T, TU>>();

        public TU this[T key]
        {
            get
            {
                SKeyValuePair<T, TU> kvp = _list.FirstOrDefault(pair => pair.Key.Equals(key));
                return kvp.Value;
            }
            set
            {
                SKeyValuePair<T, TU> kvp = _list.FirstOrDefault(pair => pair.Key.Equals(key));
                kvp.Value = value;
            }
        }

        public SKeyValuePair<T, TU> this[int index]
        {
            get
            {
                return _list[index];
            }
        }

        public bool ContainsKey(T key)
        {
            return _list.Any(x => x.Equals(key));
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
