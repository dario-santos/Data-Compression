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
        //Dicionario de programas
        private static Dictionary<string, string> programsPaths = new Dictionary<string, string>();
        private static string csharpCompressionPath = @"CSCompression\Compression.exe";
        private static string pythonCompressionPath = @"PythonCompression\source.py";
        private static string dataAnalizer = @"DataAnalizer\sizechart.py";
        
        //Benchmark files
        private static List<string> filePaths = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Inicializar();
        }
        private static void Inicializar()
        {
            filePaths.Add(@"Recursos\pequena.svg");
            filePaths.Add(@"Recursos\media.svg");
            filePaths.Add(@"Recursos\grande.svg");

            programsPaths.Add("csharpCompression", "CSCompression\\Compression.exe");
            programsPaths.Add("pythomCompression", "PythonCompression\\source.py");
            programsPaths.Add("comSizeChart", "DataAnalizer\\com_size_chart.py");
            programsPaths.Add("comTimeChart", "DataAnalizer\\com_time_chart.py");
            programsPaths.Add("decTimeChart", "DataAnalizer\\dec_size_chart.py");
        }

        private static void GenerateLogFiles()
        {
            System.IO.Directory.CreateDirectory("Temp");

            StreamWriter temp = null;
            foreach (string path in filePaths)
            {
                temp = File.CreateText("Logs\\com_gzip_" + path.Split('\\')[1] + ".txt");
                temp.Close();
                temp = File.CreateText("Logs\\com_bzip2_" + path.Split('\\')[1] + ".txt");
                temp.Close();

            }
            temp = File.CreateText("Logs\\dec_bzip2.txt");
            temp.Close();
            temp = File.CreateText("Logs\\dec_gzip.txt");
            temp.Close();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            GenerateLogFiles();
            foreach (string path in filePaths)
            {
                if(checkBoxCSCompression.Checked)
                    ExecuteProgramm(csharpCompressionPath, path);
                if(checkBoxPythonCompression.Checked)
                    ExecuteProgramm(pythonCompressionPath, path);
            }

            if (checkBoxDelTempFiles.Checked)
                Directory.Delete("Temp", true);

            if (checkBoxGenerateCharts.Checked)
                GenerateCharts();

            MessageBox.Show("Sucess.", "Operation ended");

        }

        private static void GenerateCharts()
        {
            //comp_<algortimo>_<nome_do_ficheiro>.txt
            //compressao: Tamanho, Tempo

            ExecuteProgramm(programsPaths["comSizeChart"], "Logs\\com_gzip_pequena.svg.txt");
            ExecuteProgramm(programsPaths["comTimeChart"], "Logs\\com_gzip_pequena.svg.txt");
            ExecuteProgramm(programsPaths["comSizeChart"], "Logs\\com_gzip_media.svg.txt");
            ExecuteProgramm(programsPaths["comTimeChart"], "Logs\\com_gzip_media.svg.txt");
            ExecuteProgramm(programsPaths["comSizeChart"], "Logs\\com_gzip_grande.svg.txt");
            ExecuteProgramm(programsPaths["comTimeChart"], "Logs\\com_gzip_grande.svg.txt");


            ExecuteProgramm(programsPaths["comSizeChart"], "Logs\\com_bzip2_pequena.svg.txt");
            ExecuteProgramm(programsPaths["comTimeChart"], "Logs\\com_bzip2_pequena.svg.txt");
            ExecuteProgramm(programsPaths["comSizeChart"], "Logs\\com_bzip2_media.svg.txt");
            ExecuteProgramm(programsPaths["comTimeChart"], "Logs\\com_bzip2_media.svg.txt");
            ExecuteProgramm(programsPaths["comSizeChart"], "Logs\\com_bzip2_grande.svg.txt");
            ExecuteProgramm(programsPaths["comTimeChart"], "Logs\\com_bzip2_grande.svg.txt");

            //descompressao: Tempo
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
