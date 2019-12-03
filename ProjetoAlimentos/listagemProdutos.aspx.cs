using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ProjetoAlimentos
{
    public partial class listagemProdutos : System.Web.UI.Page
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}