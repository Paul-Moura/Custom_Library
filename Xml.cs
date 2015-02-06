using System;
using System.IO;
using System.Xml.Serialization;

namespace Custom
{
    public static class Xml
    {
        public static void Serialize(string file, object o)
        {
            var serializer = new XmlSerializer(o.GetType());
            var writer = new StreamWriter(file, false);
            serializer.Serialize(writer, o);
            writer.Close();
        }

        public static object Deserialize(string file, Type t)
        {
            if (!File.Exists(file)) return null;

            var serializer = new XmlSerializer(t);
            var reader = new StreamReader(file);
            var obj = serializer.Deserialize(reader);
            reader.Close();

            return obj;
        }
    }
}
