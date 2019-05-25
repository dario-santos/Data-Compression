using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Data_Compression_UI
{
    public partial class Form1 : Form
    {
        //Program paths
        //Dicionario de programas
        private static Dictionary<string, string> programsPaths = new Dictionary<string, string>();

        //Benchmark files
        private static List<string> filePaths = new List<string>();

        //Images names
        private static List<string> images = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Inicializar();
            Log.Initialize(images);
            treeViewChartList.ExpandAll();
        }

        private static void Inicializar()
        {
            // Imagens
            images.Add("pequena.svg");
            images.Add("media.svg");
            images.Add("grande.svg");

            // Caminhos das imagens e dos logs
            foreach (string path in images)
                filePaths.Add("Recursos\\" + path);

            //Caminhos dos Programas
            programsPaths.Add("csharpCompression", "CSCompression\\Compression.exe");
            programsPaths.Add("pythomCompression", "PythonCompression\\source.exe");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            progressBarBenchmark.Value = 0;
            CheckBox[] checkBoxes = {checkBoxCSharpBenchmark, checkBoxPythonBenchmark};
            progressBarBenchmark.Maximum = ProgressBar.SetMaximum(checkBoxes, images.Count);

            Log.GenerateFiles();

            foreach (string path in filePaths)
            {
                if (checkBoxCSharpBenchmark.Checked)
                {
                    Terminal.ExecuteProgramm(programsPaths["csharpCompression"], path);
                    progressBarBenchmark.Value += 1;
                }
                if (checkBoxPythonBenchmark.Checked)
                {
                    Terminal.ExecuteProgramm(programsPaths["pythomCompression"], path);
                    progressBarBenchmark.Value += 1;
                }
            }
                    
            if (checkBoxDelTempFiles.Checked)
                Directory.Delete("Temp", true);

            if(checkBoxCSharpBenchmark.Checked || checkBoxPythonBenchmark.Checked)
                Chart.canGenerate = true;
            else
                Chart.canGenerate = false;

            MessageBox.Show("Completed.", "Operation has ended.");

            progressBarBenchmark.Value = 0;
            buttonStart.Enabled = true;
        }

        private void TreeViewChartList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Chart.AskForChart(e.Node.Name);
        }

    }
}
