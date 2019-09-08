using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoAlimentos
{
    public partial class produtos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
                Response.Redirect("default.aspx");
        }

        protected void btnCadastra_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            bool flag =  con.insereProduto(txtDescricao.Text,
                            Convert.ToInt32(ddlTipo.SelectedValue),
                            Convert.ToDouble(txtDensidade.Text)
                            );
            if (flag == true)
            {
                string title = "Cadastro";
                string body = "Produto cadastrado com sucesso :)";
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + title + "', '" + body + "');", true);
            }
            else
               lblmsg.Text = con.mensagem;
        }
    }
}