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
            if(txtUser.Text == "adm" &&
                txtsenha.Text == "sinfo")
            {
                Session["login"] = txtUser.Text;
                Response.Redirect("dashboard.aspx");
            }// fim if

        }
    }
}