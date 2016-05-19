using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeste3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter arquivo = null;
            Stopwatch relogio = new Stopwatch();
            relogio.Start();
            try
            {
                string nomeArquivo = "primos.txt";
                string caminhoArquivo = @"E:\S2B\Visual Studio 2015\Projects\ConsoleTeste3";
                nomeArquivo = Path.Combine(caminhoArquivo, nomeArquivo);
                arquivo = new StreamWriter(nomeArquivo);
                arquivo.WriteLine("Números primos");
                int N = 100000;
                bool primo;
                for (int i = 0; i < N; i++)
                {
                    primo = true;
                    for (int l = 2; l < i; l++)
                    {
                        if (i % l == 0)
                        {
                            primo = false;
                            break;
                        }
                    }
                    if (primo && i > 1)
                    {
                        //Console.WriteLine(i + " eh primo");
                        arquivo.WriteLine(i);
                    }
                }
                
            }
            catch (Exception error)
            {
                Console.WriteLine("Erro: " + error.Message);
            }
            finally
            {
                relogio.Stop();
                long tempo = relogio.ElapsedMilliseconds;
                arquivo.WriteLine("Tempo de execução: " + tempo.ToString() + " ms.");
                arquivo.Close();
                Console.ReadKey();
            }
        }
    }
}
