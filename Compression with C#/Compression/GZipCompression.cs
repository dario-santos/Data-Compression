﻿using System.IO;
using System.Diagnostics;
using ICSharpCode.SharpZipLib.GZip;

namespace Compression
{
    /// <summary>
    /// GZip compression algorithm.
    /// </summary>
    class GZipCompression : CompressionAlgorithm
    {
        public GZipCompression(string extension, int minCompressionLevel = 1, int maxCompressionLevel = 9) 
            : base(extension, minCompressionLevel, maxCompressionLevel)
        {
        }
        
        /// <summary>
        /// Compresses a given file using the GZip Algorithm.
        /// </summary>
        /// <param name="fInput">The file to compress.</param>
        /// <param name="dataUnit">The unit that will be saved in the log file</param>
        public override void Compress(FileInfo fInput = null, DataUnits dataUnit = DataUnits.Byte)
        {
            StreamWriter fLog = File.CreateText("log_compress.txt");
            Stopwatch timer = new Stopwatch();
            FileInfo info = null;

            for(int i = MinCompressionLevel ; i <= MaxCompressionLevel ; i++)
            {
                timer.Start();

                using(FileStream fInputStream = fInput.OpenRead())
                    using(FileStream fOutputStream = File.Create(fInput.FullName + i + Extension))
                        GZip.Compress(fInputStream, fOutputStream, true, level:i);

                timer.Stop();

                info = new FileInfo(fInput.FullName + i + Extension);

                fLog.WriteLine(i + " " +  Byte.ConvertTo(info.Length, dataUnit)+ " " + timer.Elapsed.TotalSeconds.ToString("n2") + " GZIP");
            }
            fLog.Close();
        }

        /// <summary>
        /// Decompresses the given files using the Gzip algorithm.
        /// </summary>
        /// <param name="fInput">The file to decompress.</param>
        public override void Decompress(string fName = null)
        {
            FileInfo fInput = new FileInfo(fName + MaxCompressionLevel + Extension);
            StreamWriter fLog = File.CreateText("log_decompress.txt");
            Stopwatch timer = new Stopwatch();
            
            timer.Start();

            using(FileStream fInputStream = fInput.OpenRead())
                using(FileStream fOutputStream = File.Create(fName))
                    GZip.Decompress(fInputStream, fOutputStream, true);

            timer.Stop();

            fLog.WriteLine(fName + timer.Elapsed.TotalSeconds.ToString("n2") + " GZIP");

            fLog.Close();
        }
    }
}