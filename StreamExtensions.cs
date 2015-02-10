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
            //var buffer = new byte[1024*8];
            //int len;
            //while ((len = stream.Read(buffer, 0, buffer.Length)) > 0)
            //{
            //    fileStream.Write(buffer, 0, len);
            //}
        }
    }
}
