using System;

namespace Custom
{
    [Serializable]
    public class SKeyValuePair<T, TU>
    {
        public T Key { get; private set; }

        public TU Value { get; set; }

        public SKeyValuePair(T key, TU value)
        {
            Key = key;
            Value = value;
        }
    }
}
