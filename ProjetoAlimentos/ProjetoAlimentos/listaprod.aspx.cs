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
            DataSet ds = con.listaProdutos();
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
    }
}