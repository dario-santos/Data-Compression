using System.Diagnostics;

namespace Data_Compression_UI
{
    /// <summary>
    /// Methods relative to the Terminal
    /// </summary>
    class Terminal
    {

        /// <summary>
        /// Executes a the .exe file in the path with the given arguments
        /// </summary>
        /// <param name="path">Program path.</param>
        /// <param name="arg">Terminal argumentos of the program.</param>
        public static void ExecuteProgramm(string path, string arg)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.CreateNoWindow = false;
            startInfo.FileName = path;
            startInfo.Arguments = arg;

            Process proc = Process.Start(startInfo);

            while (!proc.HasExited) ;
        }
    }
}
