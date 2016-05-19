using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class ContaCorrente
    {
        #region "Memoria Privada"
        private string nomeTitular;
        private decimal saldo;
        private DateTime dataCriacao;
        private decimal saldoAcomulado;
        private int contador;
        #endregion

        #region "Propriedades Públicas"
        public string NomeTitular
        {
            set { nomeTitular = value; }
            get { return nomeTitular; }
        }
        public decimal Saldo
        {
            set { saldo = value; }
            get { return saldo; }
        }
        public DateTime DataCriacao
        {
            get { return dataCriacao; }
        }
        public decimal SaldoAcomulado
        {
            get { return saldoAcomulado; }
            set { saldoAcomulado = value; }
        }
        public int Contador
        {
            get { return contador; }
            set { contador = value; }
        }
        #endregion

        #region "Metodos Privados"
        public void Depositar(decimal val)
        {
            Saldo += val;
            this.SaldoAcomulado += this.Saldo;
            this.Contador++;
        }
        public void Retirada(decimal val)
        {
            Saldo -= val;
            this.SaldoAcomulado += this.Saldo;
            this.Contador++;
        }
        public decimal SaldoMedio()
        {
            decimal medio;
            try
            {
                medio = (this.SaldoAcomulado / this.Contador);
            }
            catch(Exception Erro)
            {
                // Console.WriteLine("Erro: " + Erro.Message);
                medio = 0;
            }
            return medio;
        }
        #endregion

        #region "Construtores"
        public ContaCorrente()
        {
            dataCriacao = DateTime.Now;
            this.Contador = 0;
            this.SaldoAcomulado = 0;
        }
        public ContaCorrente(string nome) : this()
        {
            nomeTitular = nome;
        }
        public ContaCorrente(string nome, decimal val) : this(nome)
        {
            saldo = val;
            saldoAcomulado = saldo;
            contador = 1;
        }
        #endregion
    }
}
