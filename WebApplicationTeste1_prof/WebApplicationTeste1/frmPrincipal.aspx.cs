using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTeste1
{
    public partial class frmPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // verifica se usuário está logado.
            string strUsuario = Session["usuario"] + "";
            if(strUsuario.Length==0)
            {
                Response.Redirect("frmLogin.aspx");
            }
        }

        protected void cmdOK_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.lblMensagem.Text.ToUpper() == "OLÁ, MUNDO!")
                {
                    this.lblMensagem.Text = "Tchau, mundo!";
                }
                else
                {
                    this.lblMensagem.Text = "Olá, mundo!";
                }
            }
            catch(Exception Erro)
            {
                lblMensagem.Text = "Erro: " + Erro.Message;
            }
        }

        protected void cmdDados_Click(object sender, EventArgs e)
        {

            List<clPessoa> Lista = new List<clPessoa>();

            clPessoa P = new clPessoa
            {
                CPF = "1234",
                Nome = "Filipo",
                DataNascimento = DateTime.Now.AddYears(-20)
            };
            clPessoa Q = new clPessoa
            {
                CPF = "4321",
                Nome = "Ze",
                DataNascimento = DateTime.Now.AddYears(-30)
            };
            clPessoa T = new clPessoa
            {
                CPF = "6543",
                Nome = "Maria",
                DataNascimento = DateTime.Now.AddYears(-35)
            };

            Lista.Add(P);
            Lista.Add(Q);
            Lista.Add(T);

            this.grdDados.DataSource = Lista;
            this.grdDados.DataBind();
            

        }
    }
}