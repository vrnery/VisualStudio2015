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
            if(strUsuario.Length == 0)
            {
                Response.Redirect("frmLogin.aspx");
            }
        }

        protected void cmdOk_Click(object sender, EventArgs e)
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
                    this.lblMensagem.Text.ToUpper();
                }
                
            }
            catch(Exception Erro)
            {
                lblMensagem.Text = "Erro: " + Erro.Message;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cmdDados_Click(object sender, EventArgs e)
        {
            List<clPessoa> lista = new List<clPessoa>();

            clPessoa P = new clPessoa("Filipo", "1234", DateTime.Now.AddYears(-20), clPessoa.enmGenero.Masculino);
            clPessoa Q = new clPessoa("Ze", "4321", DateTime.Now.AddYears(-30), clPessoa.enmGenero.Masculino);
            clPessoa T = new clPessoa("Maria", "6543", DateTime.Now.AddYears(-35), clPessoa.enmGenero.Feminino);

            lista.Add(P);
            lista.Add(Q);
            lista.Add(T);

            this.grdDados.DataSource = lista;
            this.grdDados.DataBind();
        }
    }
}