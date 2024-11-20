using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp
{
    internal class BTCBRL
    {
        public static string ObterCotacaoBTCBRL()
        {
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = @"C:\Users\Thomas\AppData\Local\Programs\Python\Python312\python.exe", // Caminho do executável Python
                Arguments = @"C:\Users\Thomas\Documents\GitHub\ProjectApiCotacao\BTCBRL.py", // Caminho completo do script BTCBRL.py
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(start))
            using (System.IO.StreamReader reader = process.StandardOutput)
            {
                return reader.ReadToEnd().Trim();
            }
        }
    }

    internal class EURBRL
    {
        public static string ObterCotacaoEURBRL()
        {
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = @"C:\Users\Thomas\AppData\Local\Programs\Python\Python312\python.exe", // Caminho do executável Python
                Arguments = @"C:\Users\Thomas\Documents\GitHub\ProjectApiCotacao\EURBRL.py", // Caminho completo do script BTCBRL.py
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(start))
            using (System.IO.StreamReader reader = process.StandardOutput)
            {
                return reader.ReadToEnd().Trim();
            }
        }
    }
    internal class USDBRL
    {
        public static string ObterCotacaoUSDBRL()
        {
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = @"C:\Users\Thomas\AppData\Local\Programs\Python\Python312\python.exe", // Caminho do executável Python
                Arguments = @"C:\Users\Thomas\Documents\GitHub\ProjectApiCotacao\USDBRL.py", // Caminho completo do script BTCBRL.py
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(start))
            using (System.IO.StreamReader reader = process.StandardOutput)
            {
                return reader.ReadToEnd().Trim();
            }
        }
    }
}
