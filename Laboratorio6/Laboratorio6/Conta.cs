using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    public abstract class Conta
    {
        private string titular;
        private decimal saldo;

        public Conta(string t)
        {
            titular = t;
        }

        public string Titular
        {
            get { return titular; }
        }
        public decimal Saldo
        {
            get { return saldo; }
        }
        public abstract string Id
        {
            get;
        }

        public virtual void Depositar(decimal valor)
        {
            saldo += valor;
        }
        public virtual void Sacar(decimal valor)
        {
            saldo -= valor;
        }
    }
}
