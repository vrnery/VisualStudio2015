using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeste2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string nomeArquivo = "teste.txt";
                string caminhoArquivo = @"C:\Users\sala312\documents\visual studio 2015\Projects\ConsoleTeste2";
                nomeArquivo = Path.Combine(caminhoArquivo, nomeArquivo);
                StreamReader arquivo = new StreamReader(nomeArquivo);
                Console.WriteLine("Conteúdo do arquivo " + nomeArquivo);
                while (!arquivo.EndOfStream)
                {
                    string linha = arquivo.ReadLine();
                    Console.WriteLine(linha);
                }
                arquivo.Close();
                Console.ReadKey();
            } catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }
    }
}
