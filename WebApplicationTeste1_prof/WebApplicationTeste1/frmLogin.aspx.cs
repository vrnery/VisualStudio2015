using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTeste1
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // usuário pediu para ser lembrado?
            if(Request.Cookies["lembrarUsuario"] != null)
            {
                this.chkLembrar.Checked = true;
                this.txtUsuario.Text = Server.HtmlEncode
                    (Request.Cookies["lembrarUsuario"].Value);
            }
        }

        protected void cmdOK_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txtUsuario.Text.ToUpper().Trim() == "FILIPO")
                {
                    if(this.txtSenha.Text== "1234")
                    {
                        // usuário e senha estão corretos!
                        Session.Add("usuario", this.txtUsuario.Text.ToUpper().Trim());

                        // usuário pediu para lembrar?
                        if(this.chkLembrar.Checked)
                        {
                            HttpCookie objCookie = new HttpCookie("lembrarUsuario");
                            objCookie.Value = this.txtUsuario.Text.ToUpper().Trim();
                            objCookie.Expires = DateTime.Now.AddDays(10);
                            Response.Cookies.Add(objCookie);
                        }
                        Response.Redirect("frmPrincipal.aspx");
                    }
                }
            }
            catch(Exception Erro)
            {
                this.lblMensagem.Text = "Erro: " + Erro.Message;
            }
        }
    }
}