using System.Windows.Forms;

namespace Data_Compression_UI
{
    class Chart
    {
        public static string comSize = "DataAnalizer\\com_size_chart.exe";
        public static string comTime = "DataAnalizer\\com_time_chart.exe";
        public static string decTime = "DataAnalizer\\dec_time_chart.exe";
        public static bool canGenerate = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logPath">Path to the log file.</param>
        /// <param name="chartType"> Compress = true. Decompress = false.</param>
        public static void Generate(string logPath, bool chartType)
        {
            if(chartType)
            {
                //compressao: Tamanho, Tempo
                Terminal.ExecuteProgramm(comSize, logPath);
                Terminal.ExecuteProgramm(comTime, logPath);
            }
            else
            {
                //Descompressao
                Terminal.ExecuteProgramm(decTime, logPath);
            }
        }

        public static void AskForChart(string name)
        {
            if(!canGenerate)
            {
                MessageBox.Show("You need to perform the benchmark first.", "Error.");
                return;
            }

            //com_<algoritmo>_<nome> ou dec_<algoritmo>
            string[] nodeName = name.Split('_');

            //compressao
            if(nodeName[0].Equals("com") && nodeName.Length == 3)
                Generate("Logs\\" + name + ".svg.txt", true);

            //decompressao
            if(nodeName[0].Equals("dec") && nodeName.Length == 2)
                Generate("Logs\\" + name + ".txt", false);
        }
    }
}
