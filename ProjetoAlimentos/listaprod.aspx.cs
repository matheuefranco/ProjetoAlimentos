using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ProjetoAlimentos
{
    public partial class listaprod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                preencheGrid();
        }
        void preencheGrid()
        {
            ConectaBanco con = new ConectaBanco();
            DataSet ds = new DataSet();
            ds = con.listagemProd();
            gvdados.DataSource = ds;
            gvdados.DataBind();
        }

        protected void gvdados_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvdados.EditIndex = e.NewEditIndex;
            preencheGrid();
        }

        protected void gvdados_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvdados.EditIndex = -1;
            preencheGrid();
        }

        protected void gvdados_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(gvdados.DataKeys[e.RowIndex].Value.ToString());
            string desc = ((TextBox)gvdados.Rows[e.RowIndex].FindControl("txtprod")).Text;
            double densidade = Convert.ToDouble(((TextBox)gvdados.Rows[e.RowIndex].FindControl("txtdensidade")).Text);
            int tipo = Convert.ToInt32(((DropDownList)gvdados.Rows[e.RowIndex].FindControl("ddltipo")).SelectedValue);
            ConectaBanco con = new ConectaBanco();
            bool flag = con.updateProduto(id,desc,densidade,tipo);
            if (flag == true)
            {
                string title = "Update Produto";
                string body = "Produto atualizado com sucesso :)";
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + title + "', '" + body + "');", true);
            }
            else
                lblmsg.Text = con.mensagem;

            gvdados.EditIndex = -1;
            preencheGrid();
        }

        protected void gvdados_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Session["id_prod"] = gvdados.DataKeys[e.NewSelectedIndex].Value.ToString();
            Session["nome_prod"] =
                ( (Label) gvdados.Rows[e.NewSelectedIndex].FindControl("lblprod") ).Text;
            Response.Redirect("listaItens.aspx");
        }

        protected void gvdados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}