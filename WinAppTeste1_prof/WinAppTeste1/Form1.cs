using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinAppTeste1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {

            try
            {
                clPessoa Pessoa = new clPessoa("Filipo", "41165174375",
                                               DateTime.Parse("10/10/1980"),
                                               clPessoa.enmGenero.Masculino);
                //clPessoa x = new clPessoa()
                //Pessoa.Nome    = "Filipo";
                //Pessoa.CPF     = "1234";
                //Pessoa.DT_Nasc = DateTime.Parse("05/04/1980");
                //Pessoa.Genero  = clPessoa.enmGenero.Masculino;

                //int idade = DateTime.Now.Year - Pessoa.DT_Nasc.Year;
                //int idade = Pessoa.Idade;
                this.txtSaida.Text += Pessoa.Nome + " - " +
                                      Pessoa.CPF + " - " +
                                      Pessoa.DT_Nasc.ToShortDateString() + " - " +
                                      Pessoa.Genero.ToString() + " - " +
                                      Pessoa.Idade.ToString() + " anos" +
                                      Environment.NewLine;

                 
            }
            catch(Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmdArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                List<clPessoa> Pessoas = new List<clPessoa>();
                //string caminhoArquivo = Path.Combine(@"C:\Users\sala312\Downloads\Projetos", "dados.csv");
                string caminhoArquivo = Path.Combine(Application.StartupPath, "dados.csv"); // busca o arquivo na mesma pasta do executável (Debug ou Release).
                StreamReader arquivo = new StreamReader(caminhoArquivo);
                while(!arquivo.EndOfStream)
                {
                    string strLinha = arquivo.ReadLine().Trim();
                    if( strLinha.Length==0)
                    {
                        continue;
                    }
                    string[] campos     = strLinha.Split(';');
                    string strNome      = campos[0].Trim();
                    string strCPF       = campos[1].Trim();
                    DateTime datDT_Nasc = DateTime.Parse(campos[2]);

                    clPessoa.enmGenero enuGenero;
                    if (campos[3].Trim() == "0")
                    {
                        enuGenero = clPessoa.enmGenero.Feminino;
                    }
                    else
                    {
                        enuGenero = clPessoa.enmGenero.Masculino;
                    }
                    //clPessoa.enmGenero enuGenero = 
                    //    (campos[3].Trim() == "0" ? 
                    //     clPessoa.enmGenero.Feminino : clPessoa.enmGenero.Masculino);

                    Pessoas.Add(new clPessoa(strNome, strCPF, datDT_Nasc, enuGenero));
                }

                // Lista as pessoas adicionadas
                this.txtSaida.Text = null;
                foreach(clPessoa p in Pessoas)
                {
                    this.txtSaida.Text += p.ToString() + 
                                          Environment.NewLine + 
                                          "-----------------------------------------" + 
                                          Environment.NewLine;
                }
            }
            catch(Exception Erro)
            {
                MessageBox.Show( Erro.Message, 
                                "Erro processando arquivo!", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                clPessoa Pessoa = new clPessoa("Joao",
                                               "92632431239", 
                                               DateTime.Now.AddYears(-20), 
                                               clPessoa.enmGenero.Masculino);
                Pessoa.Enderecos.Add(new clEndereco("Rua x", "10"));
                Pessoa.Enderecos.Add(new clEndereco("Avenida y", "20"));
                Pessoa.Enderecos.Add(new clEndereco("Avenida wtr", "30"));
                Pessoa.Salvar();

                this.txtSaida.Text += Pessoa.ToString() + Environment.NewLine;
                this.txtSaida.Text += Pessoa.ToString("f") + Environment.NewLine;
                this.txtSaida.Text += Pessoa.ToString("l") + Environment.NewLine;
                this.txtSaida.Text += Pessoa.ToString("n") + Environment.NewLine;
                this.txtSaida.Text += Pessoa.ToString("na") + Environment.NewLine;

            }
            catch(Exception Erro)
            {
                MessageBox.Show( Erro.Message, 
                                "Erro Salvando!", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        private void cmdProfessor_Click(object sender, EventArgs e)
        {
            clProfessor Prof = new clProfessor();

            Prof.Nome = "Filipo";
            Prof.Titulacao = enmTitulacao.Mestrado | enmTitulacao.Doutor;
        }
    }
}
