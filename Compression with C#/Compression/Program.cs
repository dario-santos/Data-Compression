using System;
using System.IO;

namespace Compression
{
    class Program
    {
        private static int Main(string[] args)
        {
            DefaultDot();
            CompressionAlgorithm gzip = new GZipCompression(".gz");
            CompressionAlgorithm bzip2 = new BZip2Compression(".bz2");
            
            string fInputPath = EvaluateFilePath(args);
            if(fInputPath.Equals(null))
                return -1;

            FileInfo fInput = new FileInfo(fInputPath);
            if(fInput.Equals(null))
                return -1;

            gzip.Compress(fInput, DataUnits.MegaByte);
            bzip2.Compress(fInput, DataUnits.MegaByte);

            gzip.Decompress(fInput.Name);
            bzip2.Decompress(fInput.Name);
            return 1;
        }

        /// <summary>
        /// Evaluates the path to the choosen file to compress from the different possibilities.
        /// </summary>
        /// <param name="args">The arguments givin by the terminal.</param>
        /// <returns>The path of the file to compress.</returns>
        private static string EvaluateFilePath(string[] args)
        {
            if(args.Length != 1 && !File.Exists("compress.svg"))
            {
                Console.WriteLine("\n\nError: The file does not exists or invalid number of arguments");
                Console.WriteLine("Input the file trougth the terminal or place a file named compress.svg in the program directory.\n\n");
                return null;
            }

            //The file to use is the given by the terminal
            if(args.Length == 1)
            {
                if(!File.Exists(args[0]))
                {
                    Console.WriteLine("\n\nError: The file does not exists\n\n");
                    Console.WriteLine("Place the file in the program directory.\n\n");
                    return null;
                }
                return args[0];
            }

            //The file do compress is the default one
            if(File.Exists("compress.svg"))
            {
                return "compress.svg";
            }
            return null;
        }

        /// <summary>
        /// Defaults the decimal separator to a dot instead of a comma.
        /// </summary>
        private static void DefaultDot()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
    }
}
