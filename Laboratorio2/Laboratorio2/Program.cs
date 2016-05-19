using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Trabalhando com tipos-valor fundamentais byte, int e long
            Console.WriteLine("1 Trabalhando com tipos-valor fundamentais byte, int e long\n");
            sbyte sb = sbyte.MaxValue;
            Console.WriteLine("\tNúmero maximo de sbyte: " + sb + ", minimo: " + sbyte.MinValue);
            byte b = byte.MaxValue;
            Console.WriteLine("\tNúmero maximo de byte: " + b + ", minimo: " + byte.MinValue);
            uint ui = uint.MaxValue;
            Console.WriteLine("\tNúmero maximo de uint: " + ui + ", minimo: " + uint.MinValue);
            int i = int.MaxValue;
            Console.WriteLine("\tNúmero maximo de int: " + i + ", minimo: " + int.MinValue);
            ulong ul = ulong.MaxValue;
            Console.WriteLine("\tNúmero maximo de ulong: " + ul + ", minimo: " + ulong.MinValue);
            long l = long.MaxValue;
            Console.WriteLine("\tNúmero maximo de long: " + l + ", minimo: " + long.MinValue);

            // 2 Trabalhando com strings
            Console.WriteLine("\n\n2 Trabalhando com strings\n");
            string strPrimeiro = "Alô";
            string strSegundo = "Mundo";
            string strTerceiro = strPrimeiro + " " + strSegundo;
            Console.WriteLine("\tTipo de string: " + strTerceiro);
            int cchTamanho = strTerceiro.Length;
            string strQuarta = "\tTamanho = " + cchTamanho.ToString();
            Console.WriteLine(strQuarta);
            Console.WriteLine("\t" + strTerceiro.Substring(0, 5));

            // 3 Trabalhando com objetos do Framework
            Console.WriteLine("\n\n3 Trabalhando com objetos do Framework\n");
            DateTime dt = new DateTime(2016, 04, 29);
            string strQuinta = dt.ToString();
            Console.WriteLine("\t" + strQuinta);

            // 4 Exercícios
            Console.WriteLine("\n\n4 Exercícios\n");
            Console.WriteLine("\t1)");
            float floatF = 12.3F;
            Console.WriteLine("\tValor float = " + floatF);
            float floatF2 = 12.3F;
            Console.WriteLine("\tValor float = " + floatF2.ToString());
            double doubleD = 123.12D;
            Console.WriteLine("\tValor double = " + doubleD);
            double doubleD2 = 123.12D;
            Console.WriteLine("\tValor double = " + doubleD2.ToString());
            decimal decimalD = 43.09M;
            Console.WriteLine("\tValor decimal = " + decimalD);
            decimal decimalD2 = 43.09M;
            Console.WriteLine("\tValor decimal = " + decimalD2.ToString());

            Console.WriteLine("\n\t2) Procurar");

            Console.WriteLine("\n\t3) Procurar");

            Console.WriteLine("\n\t4)");
            int i4 = 10;
            float f4 = 0;
            f4 = i4; //conversão implícita, sem perda de dados.
            System.Console.WriteLine("\t" + f4);
            f4 = 0.5F;
            i4 = (int)f4; //conversão explícita, com perda de dados.
            System.Console.WriteLine("\t" + i4);

            Console.WriteLine("\n\t5)");
            string stringInteiro5 = "123456789";
            int valorStringInteiro5 = Convert.ToInt32(stringInteiro5);
            Console.WriteLine("\t" + valorStringInteiro5);
            Int64 valorInt645 = 123456789;
            int valorInt5 = Convert.ToInt32(valorInt645);
            Console.WriteLine("\t" + valorInt5);
            string stringInteiroGrande5 = "999999999999999999999999999999999999999999999";
            //int valorStringInteiroGrande5 = Convert.ToInt32(stringInteiroGrande5);

            Console.WriteLine("\n\t6)");
            string stringInteiro6 = "123456789";
            int valorStringInteiro6;
            bool conversao16 = Int32.TryParse(stringInteiro6, out valorStringInteiro6);
            Console.WriteLine("\tConversão efetuada:" + conversao16 + " Valor: " + valorStringInteiro6);
            string stringInteiroGrande6 = "999999999999999999999999999999999999999999999";
            int valorStringInteiroGrande6;
            bool conversao26 = Int32.TryParse(stringInteiroGrande6, out valorStringInteiroGrande6);
            Console.WriteLine("\tConversão efetuada:" + conversao26 + " Valor: " + valorStringInteiroGrande6);
            string stringLetras6 = "abc";
            double valorStringLetras6;
            bool conversao36 = Double.TryParse(stringLetras6, out valorStringLetras6);
            Console.WriteLine("\tConversão efetuada:" + conversao36 + " Valor: " + valorStringLetras6);

            Console.WriteLine("\n\t7)");
            double valorFracionado = 4.7;
            int valorInteiro1 = (int)valorFracionado;
            int valorInteiro2 = Convert.ToInt32(valorFracionado);
            Console.WriteLine("\tConversao explicita = " + valorInteiro1);
            Console.WriteLine("\tConversao metodo Convert = " + valorInteiro2);

            Console.WriteLine("\n\t8)");
            int x = 10;
            double y = 3.4;
            Console.WriteLine("\t{0} {1}", x, y);
            // Parar tela
            Console.ReadKey();
        }
    }
}
