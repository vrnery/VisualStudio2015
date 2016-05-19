using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3);
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4);
            Circulo circ5 = new Circulo();
            circ5.CentroX = 1.7;
            circ5.CentroY = 2.8;
            circ5.Raio = 2;
            Console.WriteLine(circ5);
            CirculoColorido circ6 = new CirculoColorido();
            circ6.CentroX = 2.9;
            circ6.CentroY = 4.2;
            circ6.Raio = 4;
            circ6.Cor = "azul";
            Console.WriteLine(circ6);

            List<int> lista = new List<Int32>();
            lista.Add(1);
            lista.Insert(1, 3);
            lista.Add(4);

            foreach (int l in lista)
            {
                Console.WriteLine(l);
            }

            ////////CirculoColoridoPreenchido cores = new CirculoColoridoPreenchido();
            ////////string[] teste = (Enum.GetNames(typeof(ConsoleColor))).GetEnumerator;

            ////////String nl = Environment.NewLine;
            ////////String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));

            ////////// ---------------------------------------------------------------------------------------
            ////////Console.WriteLine("{0}All the foreground colors on a constant black background.", nl);
            ////////Console.WriteLine("  (Black on black is not readable.){0}", nl);

            ////////for (int x = 0; x < colorNames.Length; x++)
            ////////{
            ////////    Console.Write("{0,2}: ", x);
            ////////    Console.BackgroundColor = ConsoleColor.Black;
            ////////    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorNames[x]);
            ////////    Console.Write("This is foreground color {0}.", colorNames[x]);
            ////////    Console.ResetColor();
            ////////    Console.WriteLine();
            ////////}
            ////////// ---------------------------------------------------------------------------------------
            ////////Console.WriteLine("{0}A constant white foreground on all the background colors.", nl);
            ////////Console.WriteLine("  (White on white is not readable.){0}", nl);

            ////////for (int x = 0; x < colorNames.Length; x++)
            ////////{
            ////////    Console.Write("{0,2}: ", x);
            ////////    Console.ForegroundColor = ConsoleColor.White;
            ////////    Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorNames[x]);
            ////////    Console.Write("This is background color {0}.", colorNames[x]);
            ////////    Console.ResetColor();
            ////////    Console.WriteLine();
            ////////}
            ////////// ---------------------------------------------------------------------------------------
        }
    }
}
