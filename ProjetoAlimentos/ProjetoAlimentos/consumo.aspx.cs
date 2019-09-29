using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ProjetoAlimentos
{
    public partial class consumo : System.Web.UI.Page
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
                listaItens();
            }// fim if
        }

        void listaItens()
        {
            ConectaBanco con = new ConectaBanco();
            lstItens.DataSource =
                con.listaItensIdProd(Convert.ToInt32(ddlProd.SelectedValue));
            lstItens.DataTextField = "desc_massa";
            lstItens.DataValueField = "iditens";
            lstItens.DataBind();
            lblmsg.Text = con.mensagem;
        }

        protected void btnCadastra_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
           bool flag= con.insereConsumo(Convert.ToInt32(lstItens.SelectedValue), 
                              txtDesc.Text,
                              Convert.ToDateTime(txtData.Text), 
                              Convert.ToDouble(txtMassa.Text));
            if (flag == true)
            {
                string title = "Cadastro";
                string body = "Consumo cadastrado com sucesso :)";
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + title + "', '" + body + "');", true);

            }
            
            // fim if
            else
                lblmsg.Text = con.mensagem;
        }

        protected void ddlProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaItens();
        }
    }
}