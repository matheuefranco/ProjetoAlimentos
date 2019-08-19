using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoAlimentos
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcessa_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            if (con.verifica(txtUser.Text, txtsenha.Text)==true)
            {
                Session["login"] = txtUser.Text;
                Response.Redirect("dashboard.aspx");
            }// fim if
            else
            {
                lblmsg.Text = con.mensagem;
                string title = "Acesso Negado";
                string body = "Usuário ou senha incorretos :(";
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + title + "', '" + body + "');", true);
            }

        }
    }
}