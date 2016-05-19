using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AppTeste1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 100000;
            bool primo;
            Stopwatch relogio = new Stopwatch();
            relogio.Start();
            for (int i=0; i<N; i++)
            {
                primo = true;
                for (int l = 2; l<i; l++)
                {
                    if(i % l == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo && i>1)
                {
                    Console.WriteLine(i + " eh primo");
                }
            }
            relogio.Stop();
            long tempo = relogio.ElapsedMilliseconds;
            Console.WriteLine("Tempo de execução: " + tempo.ToString() + " ms.");
            Console.ReadKey();
        }
    }
}
