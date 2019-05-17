using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Data_Compression_UI
{
    public partial class Form1 : Form
    {
        //Program paths
        private static string csharpCompressionPath = @"CSCompression\Compression.exe";
        private static string pythonCompressionPath = @"PythonCompression\source.py";

        //Benchmark files
        private static List<string> filePaths = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Inicializar();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            StreamWriter temp = null;
            foreach (string path in filePaths)
            {

                temp = File.CreateText("gzip" + path.Split('\\')[1] + ".txt");
                temp.Close();
                temp = File.CreateText("bzip2" + path.Split('\\')[1] + ".txt");
                temp.Close();

                ExecuteProgramm(csharpCompressionPath, path);
                ExecuteProgramm(pythonCompressionPath, path);
            }
        }
        private static void Inicializar()
        {
            filePaths.Add(@"Recursos\pequena.svg");
            filePaths.Add(@"Recursos\media.svg");
            filePaths.Add(@"Recursos\grande.svg");
        }

        private static void ExecuteProgramm(string path, string arg)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = path;
            startInfo.Arguments = arg;
            Process p = Process.Start(startInfo);
            while(!p.HasExited)
                ;
           
        }

    }
}
