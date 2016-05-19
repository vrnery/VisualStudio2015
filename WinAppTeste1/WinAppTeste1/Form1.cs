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
                //clPessoa Pessoa = new clPessoa();
                //Pessoa.Nome = "Vanderson";
                //Pessoa.CPF = "1234";
                //Pessoa.DT_Nasc = DateTime.Parse("12/10/2015");
                //Pessoa.Genero = clPessoa.enmGenero.Masculino;

                clPessoa Pessoa = new clPessoa("Vanderson", "1234", DateTime.Parse("12/10/2008"), clPessoa.enmGenero.Masculino);

                txtSaida.Text += Pessoa.Nome + " - " +
                    Pessoa.CPF + " - " +
                    Pessoa.DT_Nasc.ToShortDateString() + " - " +
                    Pessoa.Genero.ToString() + " - " +
                    Pessoa.Idade.ToString() + " anos" +
                    Environment.NewLine;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                List<clPessoa> Pessoa = new List<clPessoa>();
                string caminhoArquivo = Path.Combine(@"E:\S2B\Visual Studio 2015\Projects\WinAppTeste1", "dados.csv");
                StreamReader arquivo = new StreamReader(caminhoArquivo);
                while (!arquivo.EndOfStream)
                {
                    string strLinha = arquivo.ReadLine().Trim();
                    if (strLinha.Length == 0)
                    {
                        continue;
                    }
                    string[] campos = strLinha.Split(';');
                    string strNome = campos[0].Trim();
                    string strCPF = campos[1].Trim();
                    DateTime datDT_Nasci = DateTime.Parse(campos[2]);
                    clPessoa.enmGenero enuGenero = (campos[3].Trim() == "0" ? clPessoa.enmGenero.Feminino : clPessoa.enmGenero.Masculino);
                    Pessoa.Add(new clPessoa(strNome, strCPF, datDT_Nasci, enuGenero));
                }
                arquivo.Close();
                foreach(clPessoa p in Pessoa)
                {
                    txtSaida.Text += p.Nome + " - " +
                    p.CPF + " - " +
                    p.DT_Nasc.ToShortDateString() + " - " +
                    p.Genero.ToString() + " - " +
                    p.Idade.ToString() + " anos" +
                    Environment.NewLine;
                }
            }
            catch(Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro processando arquivo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                clPessoa Pessoa = new clPessoa("Joao", "7654", DateTime.Now.AddYears(-20), clPessoa.enmGenero.Masculino, new clEndereco("Rua x", "10"));

                //clPessoa Pessoa = new clPessoa("Joao", "7654", DateTime.Now.AddYears(-20), clPessoa.enmGenero.Masculino);
                //Pessoa.Enderecos.Add(new clEndereco("Rua x", "10"));

                Pessoa.Enderecos.Add(new clEndereco("Avenida y", "20"));
                Pessoa.Enderecos.Add(new clEndereco("Avenida wtr", "30"));

                Pessoa.Salvar();

                this.txtSaida.Text = Pessoa.ToString();
            }
            catch(Exception Erro)
            {
                MessageBox.Show(Erro.Message, "erro Salvando!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
