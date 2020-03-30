using System;
using System.Diagnostics;

namespace backend.Services
{
    public class ScriptService : IScriptService
    {
        //private static string _scriptDir = @"..\Scripts\iicDriver.sh";

        public string Bash(string cmd)
        {
            var escapedArgs = cmd.Replace("\"", "\\\"");
            Console.WriteLine("cmd tried is {"+escapedArgs+"}.");
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            var result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return result;
        }
    }
}