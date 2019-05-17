using System.IO;
using System.Diagnostics;
using ICSharpCode.SharpZipLib.BZip2;

namespace Compression
{
    /// <summary>
    /// BZip2 compression algorithm.
    /// </summary>
    class BZip2Compression : CompressionAlgorithm
    {
        public BZip2Compression(string extension, int minCompressionLevel = 1, int maxCompressionLevel = 9)
            : base(extension, minCompressionLevel, maxCompressionLevel)
        {
        }

        /// <summary>
        /// Compresses a given file using the BZip2 Algorithm.
        /// </summary>
        /// <param name="fInput">The file to compress.</param>
        /// <param name="dataUnit">The unit that will be saved in the log file</param>
        public override void Compress(FileInfo fInput = null, DataUnits dataUnit = DataUnits.Byte)
        {
            StreamWriter fLog = File.AppendText("bzip2" + fInput.Name + ".txt");
            Stopwatch timer = new Stopwatch();
            FileInfo info = null;

            for(int i = MinCompressionLevel ; i <= MaxCompressionLevel ; i++)
            {
                timer.Start();

                using(FileStream fInputStream = fInput.OpenRead())
                    using(FileStream fOutputStream = File.Create(fInput.FullName + i.ToString() + Extension))
                        BZip2.Compress(fInputStream, fOutputStream, true, level:i);

                timer.Stop();

                info = new FileInfo(fInput.FullName + i + Extension);

                fLog.WriteLine(i + " " + Byte.ConvertTo(info.Length, dataUnit) + " " + timer.Elapsed.TotalSeconds.ToString("n2") + " CSharp");
            }
            fLog.Close();
        }

        /// <summary>
        /// Decompresses the given files using the BZip2 algorithm.
        /// </summary>
        /// <param name="fCompressed">The name of the file to decompress.</param>
        public override void Decompress(string fName = null)
        {
            FileInfo fInput = new FileInfo(fName + MaxCompressionLevel + Extension);
            StreamWriter fLog = File.AppendText("log_decompress.txt");
            Stopwatch timer = new Stopwatch();

            timer.Start();

            using(FileStream fInputStream = fInput.OpenRead())
                using(FileStream fOutputStream = File.Create(fName))
                    BZip2.Decompress(fInputStream, fOutputStream, true);

            timer.Stop();

            fLog.WriteLine(fName + timer.Elapsed.TotalSeconds.ToString("n2") + " BZIP2");

            fLog.Close();
        }
    }
}
