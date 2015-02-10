using System;

namespace Custom
{
    [Serializable]
    public class SKeyValuePair<T, TU>
    {
        public T Key { get; set; }

        public TU Value { get; set; }

        protected SKeyValuePair(){} 

        public SKeyValuePair(T key, TU value)
        {
            Key = key;
            Value = value;
        }
    }
}
