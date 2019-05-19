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

        private static bool canGenerateCharts = false;
        public Form1()
        {
            InitializeComponent();
            Inicializar();
            treeViewChartList.ExpandAll();
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
            programsPaths.Add("pythomCompression", "PythonCompression\\source.exe");
            programsPaths.Add("comSizeChart", "DataAnalizer\\com_size_chart.exe");
            programsPaths.Add("comTimeChart", "DataAnalizer\\com_time_chart.exe");
            programsPaths.Add("decTimeChart", "DataAnalizer\\dec_time_chart.exe");
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
            //Inicializaçao
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

            if (checkBoxCSharpBenchmark.Checked || checkBoxPythonBenchmark.Checked)
                canGenerateCharts = true;
            else
                canGenerateCharts = false;

            MessageBox.Show("Completed.", "Operation has ended.");
            progressBarBenchmark.Value = 0;
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

        private static void GenerateCharts(string logPath, bool type)
        {
            //comp_<algortimo>_<nome_do_ficheiro>.txt
            //compressao: Tamanho, Tempo
            if (type)
            {
                ExecuteProgramm(programsPaths["comSizeChart"], logPath);
                ExecuteProgramm(programsPaths["comTimeChart"], logPath);
            }
            else
            {
                //Descompressao
                ExecuteProgramm(programsPaths["decTimeChart"], logPath);
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

        private void TreeViewChartList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Gerar graficos desse nodo
            if (e.Node.Nodes.Count == 0)
            {
                //Compressao
                if (e.Node.Parent.Parent != null)
                {
                    if (e.Node.Parent.Text.Equals("GZip"))
                    {
                        if (e.Node.Text.Equals("Pequena"))
                            GenerateCharts("Logs\\com_gzip_pequena.svg.txt", true);
                        else if (e.Node.Text.Equals("Media"))
                            GenerateCharts("Logs\\com_gzip_media.svg.txt", true);
                        else if (e.Node.Text.Equals("Grande"))
                            GenerateCharts("Logs\\com_gzip_grande.svg.txt", true);
                    }
                    else if (e.Node.Parent.Text.Equals("BZip2"))
                    {
                        if (e.Node.Text.Equals("Pequena"))
                            GenerateCharts("Logs\\com_bzip2_pequena.svg.txt", true);
                        else if (e.Node.Text.Equals("Media"))
                            GenerateCharts("Logs\\com_bzip2_media.svg.txt", true);
                        else if (e.Node.Text.Equals("Grande"))
                            GenerateCharts("Logs\\com_bzip2_grande.svg.txt", true);
                    }
                }
                else
                {
                    if (e.Node.Text.Equals("GZip"))
                        GenerateCharts("Logs\\dec_gzip.txt", false);
                    if (e.Node.Text.Equals("BZip2"))
                        GenerateCharts("Logs\\dec_bzip2.txt", false);
                }
            }  
        }
    }
}
