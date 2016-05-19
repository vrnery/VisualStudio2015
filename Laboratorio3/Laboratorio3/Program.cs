using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Escrevendo código para alocar, inicializar e acessar dados em um array de tamanho fixo
            Console.WriteLine("1 Escrevendo código para alocar, inicializar e acessar dados em um array de tamanho fixo");
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\tIndice = " + i + " & Valor = " + array[i]);
            }
            Console.WriteLine();
            string[] str = new string[3];
            int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            for (iStr = 0; iStr < 3; iStr++)
            {
                Console.WriteLine("\tIndice = " + iStr + " & Valor = " + str[iStr]);
            }
            Console.WriteLine();
            DateTime[] dt = new DateTime[2];
            int iDate;
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            for (iDate = 0; iDate < 2; iDate++)
            {
                Console.WriteLine("\tIndice = " + iDate + " & Data = " + dt[iDate].ToShortDateString());
            }

            // 4 Exercícios
            Console.WriteLine("\n\n4 Exercícios");
            Console.WriteLine("\t1)");
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            for (int i1=0; i1<array1.Length; i1++)
            {
                array1[i1] = (((i1 * array1.Length) / 3) + 10);
            }
            foreach (int i2 in array1)
            {
                Console.Write(i2 + "\t");
            }
            array2 = array1;
            Console.WriteLine();
            foreach (int i3 in array1)
            {
                Console.Write(i3 + "\t");
            }

            Console.WriteLine("\n\t2)");
            Console.WriteLine("\tMultidimensional)");
            int[,] multidimensional = new int[5, 5];
            int[] somaMatriz = new int[5] { 0, 0, 0, 0, 0 };
            for (int i4 = 0; i4 < multidimensional.GetLength(0); i4++)
            {
                Console.Write("\n");
                for (int i5 = 0; i5 < multidimensional.GetLength(1); i5++)
                {
                    multidimensional[i4, i5] = ((i4 * 2) + (i5 * 9));
                    Console.Write("\t" + multidimensional[i4, i5]);
                    somaMatriz[i5] += multidimensional[i4, i5];
                }
            }
            Console.WriteLine();
            foreach (int i6 in somaMatriz)
            {
                Console.Write("\t" + i6);
            }

            Console.WriteLine("\n\n\tJagged)");
            int[][] jagged = new int[5][];
            int[] somaJagged = new int[5] { 0, 0, 0, 0, 0 };
            jagged[0] = new int[4]; 
            //Console.WriteLine("Length " + jagged.Length);
            //Console.WriteLine("GetLength0 " + jagged.GetLength(0));
            //Console.WriteLine("[].Length " + jagged[0].Length);
            //Console.WriteLine("[].GetLength " + jagged[0].GetLength(0));
            for (int i7=0; i7< jagged.Length; i7++)
            {
                Console.Write("\n");
                jagged[i7] = new int[5];
                for (int i8=0; i8<jagged[i7].Length; i8++)
                {
                    jagged[i7][i8] = ((i7 * 2) + (i8 * 9));
                    Console.Write("\t" + jagged[i7][i8]);
                    somaJagged[i8] += jagged[i7][i8];
                }
            }
            Console.WriteLine();
            foreach (int i9 in somaJagged)
            {
                Console.Write("\t" + i9);
            }
            Console.WriteLine();
        }
    }
}
