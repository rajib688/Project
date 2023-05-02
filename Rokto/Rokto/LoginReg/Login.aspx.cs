using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rokto.LoginReg
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text!="" && txtPassword.Text!="")
            {
                string username = txtEmail.Text;
                string password = txtPassword.Text;
                if (username=="admin" && password == "123")
                {
                    Response.Redirect("~/Profile.aspx");
                }
                else
                {

                }
            }
        }
    }
}