using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WinAppTeste1
{
    class clPessoa
    {
        #region "Enumeracoes"
        public enum enmGenero
        {
            Masculino,
            Feminino
        }
        #endregion

        #region "Memoria privada"
        private string strLNome;
        private string strLCPF;
        private DateTime datLDT_Nasc;
        private enmGenero enmLGenero;
        private List<clEndereco> lstLEndereco;
        #endregion

        #region "Propriedades Públicas"
        public string Nome
        {
            set { strLNome = value; }
            get { return strLNome; }
        }
        public string CPF
        {
            set { strLCPF = value; }
            get { return strLCPF; }
        }
        public DateTime DT_Nasc
        {
            set { datLDT_Nasc = value; }
            get { return datLDT_Nasc; }
        }
        public enmGenero Genero
        {
            set { enmLGenero = value; }
            get { return enmLGenero; }
        }
        public int Idade
        {
            get { return CalculaIdade(); }
        }
        public List<clEndereco> Enderecos
        {
            set { lstLEndereco = value; }
            get { return lstLEndereco; }
        }
        #endregion

        #region "Metodos Privados"
        private int CalculaIdade()
        {
            try
            {
                int anos = DateTime.Now.Year - datLDT_Nasc.Year;
                //if (DateTime.Now.Month < datLDT_Nasc.Month || (DateTime.Now.Month == datLDT_Nasc.Month && DateTime.Now.Day < datLDT_Nasc.Day))
                if (this.datLDT_Nasc > DateTime.Now.AddYears(-anos))
                {
                    anos--;
                }
                return anos;
            }
            catch(Exception Erro)
            {
                throw Erro;
            }
        }
        private void Inserir()
        {
            try
            {
                string strCaminhoArquivo = Path.Combine(Application.StartupPath, "dados.csv");
                StreamWriter arquivo = new StreamWriter(strCaminhoArquivo, true);
                //string strLinha = this.Nome + "; " +
                //    this.CPF + "; " + this.DT_Nasc + "; " +
                //    ((this.Genero == enmGenero.Feminino) ? "0;" : "1;");

                // mais simples
                string strLinha2 = string.Format("{0}; {1}; {2}; {3};",
                    this.Nome,
                    this.CPF,
                    this.DT_Nasc.ToShortDateString(),
                    ((this.Genero == enmGenero.Feminino) ? "0" : "1"));

                arquivo.WriteLine(strLinha2);
                arquivo.Close();
            }
            catch(Exception Erro)
            {
                throw Erro;
            }
        }
        public void Alterar()
        {

        }
        public void Contar()
        {

        }
        #endregion

        #region "Metodos Públicos"
        public void Salvar()
        {
            try
            {
                // critica os dados
                if (this.Nome.Trim().Length == 0 || this.CPF.Trim().Length == 0)
                {
                    throw new Exception("Campos obrigatórios não informados!");
                }

                // insere as informacoes no arquivo
                this.Inserir();
            }
            catch(Exception Erro)
            {
                throw Erro;
            }
        }
        public void Remover()
        {

        }
        public void Buscar()
        {

        }
        public string ToStringIdentificado()
        {
            return String.Format("{0}; {1}; {2}; {3}; {4}; {5};",
                this.Nome,
                this.CPF,
                this.DT_Nasc.ToShortDateString(),
                this.Genero.ToString(),
                this.Idade,
                this.Enderecos.ToString());
        }
        public override string ToString()
        {
            return String.Format("{0}; {1}; {2}; {3}; {4}; {5};",
                this.Nome,
                this.CPF,
                this.DT_Nasc.ToShortDateString(),
                this.Genero.ToString(),
                this.Idade,
                this.Enderecos.ToString().ToString());
        }
        #endregion

        #region "Construtores"
        public clPessoa() { }
        /// <summary>
        /// Construtor da classe clPessoa com nome.
        /// </summary>
        /// <param name="Nome">Nome da pessoa</param>
        public clPessoa(string Nome)
        {
            this.Enderecos = new List<clEndereco>();
            this.Nome = Nome;
        }
        /// <summary>
        /// Construtor da classe clPessoa com nome, cpf.
        /// </summary>
        /// <param name="Nome">Nome da Pessoa</param>
        /// <param name="CPF">CPF da Pessoa</param>
        public clPessoa(string Nome, string CPF) : this(Nome)
        {
            this.CPF = CPF;
        }
        /// <summary>
        /// Construtor da classe clPessoa com nome, cpf, data_nascimento.
        /// </summary>
        /// <param name="Nome">Nome da Pessoa</param>
        /// <param name="CPF">CPF da Pessoa</param>
        /// <param name="DT_Nasc">Data_Nascimento da Pessoa</param>
        public clPessoa(string Nome, string CPF, DateTime DT_Nasc):this(Nome, CPF)
        {
            this.DT_Nasc = DT_Nasc;
        }
        /// <summary>
        /// Construtor da classe clPessoa com nome, cpf, data_nascimento, genero.
        /// </summary>
        /// <param name="Nome">Nome da Pessoa</param>
        /// <param name="CPF">CPF da Pessoa</param>
        /// <param name="DT_Nasc">Data_Nascimento da Pessoa</param>
        /// <param name="Genero">Genero da Pessoa</param>
        public clPessoa(string Nome, string CPF, DateTime DT_Nasc, enmGenero Genero): this(Nome, CPF, DT_Nasc)
        {
            this.Genero = Genero;
        }
        /// <summary>
        /// Construtor da classe clPessoa com nome, cpf, data_nascimento, genero, endereço.
        /// </summary>
        /// <param name="Nome">Nome da Pessoa</param>
        /// <param name="CPF">CPF da Pessoa</param>
        /// <param name="DT_Nasc">Data_Nascimento da Pessoa</param>
        /// <param name="Genero">Genero da Pessoa</param>
        /// <param name="Endereco">Endereço da Pessoa</param>
        public clPessoa(string Nome, string CPF, DateTime DT_Nasc, enmGenero Genero, clEndereco Endereco) : this(Nome, CPF, DT_Nasc, Genero)
        {
            this.Enderecos.Add(Endereco);
        }
        #endregion
    }
}
