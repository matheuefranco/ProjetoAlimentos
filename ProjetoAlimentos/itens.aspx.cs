using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ProjetoAlimentos
{
    public partial class itens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ConectaBanco con = new ConectaBanco();
                DataSet ds = con.listaProdutos();
                ddlProd.DataSource = ds; // definindo a fonte de dados
                ddlProd.DataTextField = "desc_prod";
                ddlProd.DataValueField = "idprodutos";
                ddlProd.DataBind(); // popula o dropdownList
                lblmsg.Text = con.mensagem;
            }// fim if

            if (!Page.IsPostBack)
                ViewState["PageAnterior"] = Request.UrlReferrer.ToString();
        }

        protected void btnCadastra_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            bool flag = con.insereItens(txtDesc.Text,
                            Convert.ToDouble(txtMassa.Text),
                            Convert.ToInt32(ddlProd.SelectedValue));
            if (flag == true)
            {
                string title = "Cadastro";
                string body = "Item cadastrado com sucesso :)";
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + title + "', '" + body + "');", true);
            }
            else
                lblmsg.Text = con.mensagem;
        }

        protected void btnVoltar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(ViewState["PageAnterior"].ToString());
        }

        protected void btnConsumo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("consumo.aspx");
        }
    }
}