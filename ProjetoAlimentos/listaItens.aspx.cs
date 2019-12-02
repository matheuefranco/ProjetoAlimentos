using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ProjetoAlimentos
{
    public partial class listaItens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_prod"] == null)
                Response.Redirect("listaprod.aspx");

            if (!Page.IsPostBack)
            {
                ConectaBanco con = new ConectaBanco();
                int id =Convert.ToInt32(Session["id_prod"]);
                lblProd.Text =Convert.ToString(Session["nome_prod"]);
                gvItens.DataSource = con.listaItensIdProd(id);
                gvItens.DataBind();
                lblmsg.Text = con.mensagem;
            }
        }
    }
}