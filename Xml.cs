using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Custom
{
    public static class Xml
    {
	    public static void Serialize(string file, object o)
		{
			var fi = new FileInfo(file);
			var di = fi.Directory;
			if (di != null && !di.Exists)
			{
				di.Create();
			}

			var serializer = new XmlSerializer(o.GetType());
			var writer = new StreamWriter(file, false);
			serializer.Serialize(writer, o);
			writer.Close();
	    }

        public static T Deserialize<T>(string file)
        {
	        T obj = default(T);

	        if (!File.Exists(file)) return obj;

			var serializer = new XmlSerializer(typeof(T));
			var stream = new FileStream(file, FileMode.Open);
			obj = (T)serializer.Deserialize(stream);
			stream.Close();

            return obj;
        }

		public static object Deserialize(string file, Type t)
		{
			object obj = null;

			if (!File.Exists(file)) return obj;

			var serializer = new XmlSerializer(t);
			var stream = new FileStream(file, FileMode.Open);
			obj = serializer.Deserialize(stream);
			stream.Close();

			return obj;
		}
    }
}
