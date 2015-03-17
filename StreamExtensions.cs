using System.IO;

namespace Custom
{
    public static class StreamExtensions
    {
        public static void SaveToFile(this Stream stream, string file, FileMode mode = FileMode.Create, FileAccess access = FileAccess.Write, FileShare share = FileShare.Read)
        {
            var fileStream = new FileStream(file, mode, access, share);
            stream.CopyTo(fileStream);
            fileStream.Close();
            stream.Close();
        }

	    public static byte[] ReadAll(this Stream stream)
	    {
		    byte[] bytes;

		    using (var br = new BinaryReader(stream))
		    {
			    bytes = br.ReadBytes((int) stream.Length);
		    }

		    return bytes;
	    }
    }
}
