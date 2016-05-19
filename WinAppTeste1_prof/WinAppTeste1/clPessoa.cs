using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WinAppTeste1
{
    class clPessoa : IFormattable
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
            private List<clEndereco> lstLEnderecos = new List<clEndereco>();

        #endregion

        #region "Propriedades Públicas"

        public string Nome
        {
            set { strLNome = value; }
            get { return strLNome;  }
        }

        public string CPF
        {
            set 
            {
                if (this.ValidaCPF(value))
                {
                    strLCPF = value;
                }
                else throw new Exception("CPF Inválido!");
            }
            get { return strLCPF;  }
        }

        public DateTime DT_Nasc
        {
            set { datLDT_Nasc = value; }
            get { return datLDT_Nasc;  }
        }

        public enmGenero Genero
        {
            set { enmLGenero = value; }
            get { return enmLGenero;  }
        }

        public int Idade
        {
            get { return this.CalculaIdade(); }
        }

        public List<clEndereco> Enderecos
        {
            set { lstLEnderecos = value; }
            get { return lstLEnderecos;  }
        }

        #endregion

        #region "Metodos Privados"

            private int CalculaIdade()
        {
            try
            {
                int intIdade = DateTime.Now.Year - this.DT_Nasc.Year;
                if (this.DT_Nasc > DateTime.Now.AddYears(-intIdade))
                {
                    intIdade--;
                }
                return intIdade;
            }
            catch( Exception Erro)
            {
                throw Erro;
            }
        }

            private void Inserir()
            {
                try
                {
                    string strArquivo = Path.Combine(Application.LocalUserAppDataPath, "dados.csv");

                    StreamWriter arquivo = new StreamWriter(strArquivo, true);
                    //string strLinha = this.Nome + "; " +
                    //                  this.CPF + "; " +
                    //                  this.datLDT_Nasc.ToShortDateString() + "; " +
                    //                  (this.Genero == enmGenero.Feminino ? "0; " : "1; ");
                    string strLinha = String.Format("{0}; {1}; {2}; {3}; ", 
                                      this.Nome, 
                                      this.CPF, 
                                      this.datLDT_Nasc.ToShortDateString(), 
                                      (this.Genero == enmGenero.Feminino ? "0" : "1"));
                
                    arquivo.WriteLine(strLinha);
                    arquivo.Close();

                }
                catch(Exception Erro)
                {
                    throw Erro;
                }
            }

            private bool ValidaCPF(string CPF)
            {
                // baseado no código original de http://www.devmedia.com.br/validacao-de-cpf-e-cnpj/3950
                
                string valor = CPF.Replace(".", "");
                valor = valor.Replace("-", "");

                if (valor.Length != 11)
                {
                    return false;
                }


                bool igual = true;
                for (int i = 1; i < 11 && igual; i++)
                {
                    if (valor[i] != valor[0])
                    {
                        igual = false;
                    }
                }

                if (igual || valor == "12345678909")
                {
                    return false;
                }

                int[] numeros = new int[11];
                for (int i = 0; i < 11; i++)
                {
                    numeros[i] = int.Parse(valor[i].ToString());
                }

                int soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += (10 - i) * numeros[i];
                }

                int resultado = soma % 11;
                if (resultado == 1 || resultado == 0)
                {
                    if (numeros[9] != 0)
                    {
                        return false;
                    }
                }

                else if (numeros[9] != 11 - resultado)
                {
                    return false;
                }


                soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += (11 - i) * numeros[i];
                }
                resultado = soma % 11;

                if (resultado == 1 || resultado == 0)
                {

                    if (numeros[10] != 0)
                    {
                        return false;
                    }
                }
                else
                {
                    if (numeros[10] != 11 - resultado)
                    {
                        return false;
                    }
                }

                return true;
            }

        #endregion

        #region "Metodos Públicos"

            public void Salvar()
            {

                try
                {

                    // critica os dados
                    if(this.Nome.Trim().Length == 0 ||
                       this.CPF.Trim().Length  == 0  )
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

        public override string ToString()
        {
            return String.Format("{0}; {1}; {2}; {3}; {4};",
                                 this.Nome,
                                 this.CPF,
                                 this.DT_Nasc.ToShortDateString(),
                                 this.Genero.ToString(),
                                 this.Idade.ToString());
        }

        public string ToString (string format)
        {
            return ToString(format, null);
        }

        public string ToString (IFormatProvider formatProvider)
        {
            return ToString(null, formatProvider);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null) format = "G";
            if(formatProvider != null)
            {
                ICustomFormatter formater = formatProvider.GetFormat(this.GetType()) as ICustomFormatter;

                if(formater != null)
                {
                    return formater.Format(format, this, formatProvider);
                }
            }

            switch(format)
            {
                case "f": return this.Nome; break;
                case "l": return this.CPF; break;
                case "na": return String.Format("{0}; {1}; {2}; {3}; {4};",
                                 this.Nome,
                                 this.CPF,
                                 this.DT_Nasc.ToShortDateString(),
                                 this.Genero.ToString(),
                                 this.Idade.ToString()); break;
                case "n":
                case "G":
                default: return String.Format("Nome: {0} - {1} anos de idade.", this.Nome, this.Idade.ToString()); break;
            }
        }

        #endregion

        #region "Construtores"

        public clPessoa()
            { }

            /// <summary>
            /// Construtor da classe clPessoa.
            /// </summary>
            /// <param name="Nome">Nome da pessoa (string)</param>
            public clPessoa (string Nome)
            {
                this.Nome = Nome;
            }

            /// <summary>
            /// Construtor da classe clPessoa.
            /// </summary>
            /// <param name="Nome">Nome da pessoa (string)</param>
            /// <param name="CPF">CPF (string - aceita qualquer valor!)</param>
            public clPessoa (string Nome, string CPF): this(Nome)
            {
                this.CPF  = CPF;
            }

            public clPessoa (string Nome, string CPF, 
                             DateTime DT_Nasc, enmGenero Genero): this(Nome, CPF)
            {
                //this.Nome    = Nome;
                //this.CPF     = CPF;
                this.DT_Nasc = DT_Nasc;
                this.Genero  = Genero;
            }

        #endregion

    }
}
