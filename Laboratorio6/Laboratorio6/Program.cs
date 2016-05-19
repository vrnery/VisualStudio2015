using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca poup1 = new ContaPoupanca(0.005M, DateTime.Now, "Teste1");
            Console.WriteLine("ID: " + poup1.Id + "\tTitular: " + poup1.Titular + "\tSaldo: " + poup1.Saldo + "\nJuros: " + poup1.Juros + "\tAniversario: " + poup1.DataAniversario.Day + "/" + poup1.DataAniversario.Month + "\n");
            poup1.Depositar(100M);
            Console.WriteLine("ID: " + poup1.Id + "\tTitular: " + poup1.Titular + "\tSaldo: " + poup1.Saldo + "\nJuros: " + poup1.Juros + "\tAniversario: " + poup1.DataAniversario.Day + "/" + poup1.DataAniversario.Month + "\n");
            poup1.AdicionarRendimento();
            Console.WriteLine("ID: " + poup1.Id + "\tTitular: " + poup1.Titular + "\tSaldo: " + poup1.Saldo + "\nJuros: " + poup1.Juros + "\tAniversario: " + poup1.DataAniversario.Day + "/" + poup1.DataAniversario.Month + "\n");
            poup1.Sacar(46.78M);
            Console.WriteLine("ID: " + poup1.Id + "\tTitular: " + poup1.Titular + "\tSaldo: " + poup1.Saldo + "\nJuros: " + poup1.Juros + "\tAniversario: " + poup1.DataAniversario.Day + "/" + poup1.DataAniversario.Month + "\n");
            poup1.AdicionarRendimento();
            Console.WriteLine("ID: " + poup1.Id + "\tTitular: " + poup1.Titular + "\tSaldo: " + poup1.Saldo + "\nJuros: " + poup1.Juros + "\tAniversario: " + poup1.DataAniversario.Day + "/" + poup1.DataAniversario.Month + "\n");
            List<Conta> contas = new List<Conta>();
            contas.Add(new ContaPoupanca(0.003M, DateTime.Now, "Teste2"));
            Console.WriteLine("ID: " + ((ContaPoupanca)contas[0]).Id + "\tTitular: " + ((ContaPoupanca)contas[0]).Titular + "\tSaldo: " + ((ContaPoupanca)contas[0]).Saldo + "\nJuros: " + ((ContaPoupanca)contas[0]).Juros + "\tAniversario: " + ((ContaPoupanca)contas[0]).DataAniversario.Day + "/" + ((ContaPoupanca)contas[0]).DataAniversario.Month + "\n");
            ((ContaPoupanca)contas[0]).Depositar(30M);
            Console.WriteLine("ID: " + ((ContaPoupanca)contas[0]).Id + "\tTitular: " + ((ContaPoupanca)contas[0]).Titular + "\tSaldo: " + ((ContaPoupanca)contas[0]).Saldo + "\nJuros: " + ((ContaPoupanca)contas[0]).Juros + "\tAniversario: " + ((ContaPoupanca)contas[0]).DataAniversario.Day + "/" + ((ContaPoupanca)contas[0]).DataAniversario.Month + "\n");
        }
    }
}
