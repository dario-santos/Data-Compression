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

        //Log files
        private static List<string> logComPaths = new List<string>();
        private static List<string> logDecPaths = new List<string>();

        //Benchmark files
        private static List<string> filePaths = new List<string>();

        //Images names
        private static List<string> images = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Inicializar();
        }
        private static void Inicializar()
        {
            images.Add("pequena.svg");
            images.Add("media.svg");
            images.Add("grande.svg");

            foreach (string path in images)
            {
                filePaths.Add("Recursos\\" + path);

                //com_<algoritmo>_<path>
                logComPaths.Add("Logs\\com_bzip2_" + path + ".txt");
                logComPaths.Add("Logs\\com_gzip_" + path + ".txt");
            }

            logDecPaths.Add("Logs\\dec_bzip2.txt");
            logDecPaths.Add("Logs\\dec_gzip.txt");

            programsPaths.Add("csharpCompression", "CSCompression\\Compression.exe");
            programsPaths.Add("pythomCompression", "PythonCompression\\source.py");
            programsPaths.Add("comSizeChart", "DataAnalizer\\com_size_chart.py");
            programsPaths.Add("comTimeChart", "DataAnalizer\\com_time_chart.py");
            programsPaths.Add("decTimeChart", "DataAnalizer\\dec_size_chart.py");
        }

        private static void GenerateLogFiles()
        {
            Directory.CreateDirectory("Temp");

            Directory.CreateDirectory("Logs");

            StreamWriter temp = null;

            foreach (string path in logComPaths)
            {
                temp = File.CreateText(path);
                temp.Close();
            }

            foreach (string path in logDecPaths)
            {
                temp = File.CreateText(path);
                temp.Close();
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            progressBarBenchmark.Value = 0;
            progressBarBenchmark.Maximum = SetMaximumBenchmarkValue();
            GenerateLogFiles();

            foreach (string path in filePaths)
            {
                if (checkBoxCSharpBenchmark.Checked)
                {
                    ExecuteProgramm(programsPaths["csharpCompression"], path);
                    progressBarBenchmark.Value += 1;
                }
                if (checkBoxPythonBenchmark.Checked)
                {
                    ExecuteProgramm(programsPaths["pythomCompression"], path);
                    progressBarBenchmark.Value += 1;
                }
            }
                    
            if (checkBoxDelTempFiles.Checked)
                Directory.Delete("Temp", true);

            if (checkBoxPythonBenchmark.Checked || checkBoxCSharpBenchmark.Checked)
                if(checkBoxGenerateCharts.Checked)
                    GenerateCharts();
            else
                if(checkBoxGenerateCharts.Checked)
                    MessageBox.Show("You need to perform a benchmark to generate any chart.", "Error");

            //Se correu tudo bem mostra mensagem de sucesso.
            //MessageBox.Show("Success.", "Operation has ended.");

            buttonStart.Enabled = true;
        }

        private int SetMaximumBenchmarkValue()
        {
            int value = 0;
            if (checkBoxCSharpBenchmark.Checked)
                value += 1;
            if (checkBoxPythonBenchmark.Checked)
                value += 1;
            return value * images.Count ;
        }

        private static void GenerateCharts()
        {
            //comp_<algortimo>_<nome_do_ficheiro>.txt
            //compressao: Tamanho, Tempo
            foreach(string path in logComPaths)
            {

                ExecuteProgramm(programsPaths["comSizeChart"], path);
                ExecuteProgramm(programsPaths["comTimeChart"], path);
            }
            //descompressao: Tempo
            foreach (string path in logDecPaths)
            {
                //Tempo de compressao
            }
        }

        private static void ExecuteProgramm(string path, string arg)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            
            startInfo.FileName = path;
            startInfo.Arguments = arg;

            Process p = Process.Start(startInfo);

            while (!p.HasExited)
                ;
        }
    }
}
