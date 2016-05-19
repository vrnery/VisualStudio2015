using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente("Vanderson", 340);
            Console.WriteLine("Titular: " + minhaConta.NomeTitular +
                "\tSaldo: " + minhaConta.Saldo + "\tData Criação: " + minhaConta.DataCriacao +
                "\tSaldo Médio: " + minhaConta.SaldoMedio());
            minhaConta.Depositar(100);
            Console.WriteLine("Titular: " + minhaConta.NomeTitular +
                "\tSaldo: " + minhaConta.Saldo + "\tData Criação: " + minhaConta.DataCriacao +
                "\tSaldo Médio: " + minhaConta.SaldoMedio());
            minhaConta.Retirada(50);
            Console.WriteLine("Titular: " + minhaConta.NomeTitular +
                "\tSaldo: " + minhaConta.Saldo + "\tData Criação: " + minhaConta.DataCriacao +
                "\tSaldo Médio: " + minhaConta.SaldoMedio());
        }
    }
}
