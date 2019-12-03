using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoAlimentos
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
                Response.Redirect("default.aspx");
            else
                lblmsg.Text = "Seja bem vindo " + 
                              Session["login"].ToString();
        }

        protected void btnProdutos_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("produtos.aspx");
        }

        protected void btnItens_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("itens.aspx");
        }

        protected void btnConsumo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("listaprod.aspx");
        }
    }
}