using System;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;

namespace Data_Compression_UI
{
    class Program
    {
        
        //Programs paths
        private static string CsCompressionPath=@"CSharpCompression\Program.exe";
        private static string PyCompressionPath=@"source.py";

        //Files to compress paths
        private static List<string> filePaths = new List<string>();

        static void Main(string[] args)
        {
            Inicializar();

            StreamWriter temp = null;
            foreach(string path in filePaths)
            {
                
                temp = File.CreateText("gzip" + path.Split('\\')[1] + ".txt");
                temp.Close();
                temp = File.CreateText("bzip2" + path.Split('\\')[1] + ".txt");
                temp.Close();

                //ExecuteProgramm(CsCompressionPath, path);
                ExecuteProgramm(PyCompressionPath);
            }
        }

        private static void Inicializar()
        {
            filePaths.Add(@"Recusros\pequena.svg");
            filePaths.Add(@"Recusros\media.svg");
            filePaths.Add(@"Recusros\grande.svg");
        }

        private static void ExecuteProgramm(string path )//,string arg)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
	        startInfo.FileName = path;
//	        startInfo.Arguments = arg;
	        int id = Process.Start(startInfo).Id;
    
            if(Process.GetProcessById(id) != null)
                Process.GetProcessById(id).WaitForExit();

        }
    }
}
//Para depois meter num programa winforms