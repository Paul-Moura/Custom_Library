using System;

namespace Custom
{
    [Serializable]
    public class SKeyValuePair<T, TU>
    {
        public T Key;

        public TU Value;

        public SKeyValuePair(T key, TU value)
        {
            Key = key;
            Value = value;
        }
    }
}
