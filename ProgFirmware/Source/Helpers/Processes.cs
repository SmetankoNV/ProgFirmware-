using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFirmware.Source.Helpers
{
    public static class Processes
    {
        /// <summary>
        /// Запуск исполняемого файла 
        /// </summary>
        public static Process RunExe(string exeName, string param = null, bool isVisible = false)
        {
            var process = new Process();
            process.StartInfo.ErrorDialog = true;
            process.StartInfo.FileName = exeName;
            process.StartInfo.Arguments = param ?? string.Empty;
            process.StartInfo.WindowStyle = isVisible ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden;
            process.Start();

            return process;
        }

        /// <summary>
        /// Запуск CLI файла
        /// </summary>
        public static int RunCli(string exeName, string param, Action<string> output, Action<string> error)
        {
            var processInfo = new ProcessStartInfo(exeName, param)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true
            };

            var process = Process.Start(processInfo);
            if (process == null)
            {
                return -1;
            }

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            process.OutputDataReceived += (sender, e) =>
            {
                if (output != null && e.Data.IsValid())
                {
                    output(e.Data);
                }
            };
            process.ErrorDataReceived += (sender, e) =>
            {
                if (error != null && e.Data.IsValid())
                {
                    error(e.Data);
                }
            };

            process.WaitForExit();

            int exitCode = process.ExitCode;

            process.Close();

            return exitCode;
        }
    }
}
