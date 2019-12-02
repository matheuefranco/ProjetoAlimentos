using System;
using System.Data;
using System.Web.UI;

namespace ProjetoAlimentos
{
    public partial class ListaItensConsumo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                fillTable();
            }// fim if 
        }

        protected void btnFiltra_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            gvItensConsumo.DataSource = con.listaItensConsumoPorPeriodo(dateSt.Text,dateEnd.Text, Convert.ToInt32(lstProd.SelectedValue));
            gvItensConsumo.DataBind();
        }

        protected void limpa_Click(object sender, EventArgs e)
        {
            fillTable();
        }

        protected void fillTable()
        {
            ConectaBanco con = new ConectaBanco();
            gvItensConsumo.DataSource = con.listaItensConsumo();
            gvItensConsumo.DataBind();

            lstProd.DataSource = con.listaProdutos();
            lstProd.DataTextField = "desc_prod";
            lstProd.DataValueField = "idprodutos";
            lstProd.DataBind();
            lblmsg.Text = con.mensagem;
        }
    }
}