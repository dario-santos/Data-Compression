using System.IO;
using System.Collections.Generic;

namespace Data_Compression_UI
{
    class Log
    {
        private static List<string> comPaths = new List<string>();
        private static List<string> decPaths = new List<string>();

        public static void Initialize(List<string> images)
        {
            foreach(string path in images)
            {
                comPaths.Add("Logs\\com_bzip2_" + path + ".txt");
                comPaths.Add("Logs\\com_gzip_" + path + ".txt");
            }

            decPaths.Add("Logs\\dec_bzip2.txt");
            decPaths.Add("Logs\\dec_gzip.txt");
        }

        public static void GenerateFiles()
        {
            Directory.CreateDirectory("Temp");
            Directory.CreateDirectory("Logs");

            StreamWriter temp = null;

            foreach(string path in comPaths)
            {
                temp = File.CreateText(path);
                temp.Close();
            }

            foreach(string path in decPaths)
            {
                temp = File.CreateText(path);
                temp.Close();
            }
        }
    }
}
