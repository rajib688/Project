using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rokto.LoginReg
{
    public partial class Registration : System.Web.UI.Page
    {
        string _connectionString = @"Data Source = DESKTOP-K32T5PF; Initial Catalog = Rokto; Integrated Security = true;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DivMsg.Visible = false;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (CheckField() == false)
            {
                int savests = SaveReg();
                if (savests > 0)
                {
                    ClearField();
                    DivMsg.Visible = true;
                    lblMsg.Text = "Registration Successfully Completed !.";
                }
                else
                {
                    DivMsg.Visible = true;
                    lblMsg.Text = "Registration failed Please try again !.";
                }
            }
        }
        private void ClearField()
        {
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtPassword.Text = "";
        }
        private bool CheckField()
        {
            bool IsReq = false;
            if (txtMobile.Text == "")
            {
                lblMsg.Text = "Put up your Phone number.";
                txtMobile.Focus();
                IsReq = true;
            }
            else if (txtEmail.Text == "")
            {
                lblMsg.Text = "Put up your Email address.";
                txtEmail.Focus();
                IsReq = true;
            }
            else if (txtPassword.Text == "")
            {
                lblMsg.Text = "Put up your Password.";
                txtPassword.Focus();
                IsReq = true;
            }
            if (IsReq == true)
            {
                DivMsg.Visible = true;
            }
            else 
            {
                DivMsg.Visible = false;
            }
            return IsReq;
        }
        private int SaveReg()
        {
            int Save = 0;
            SqlConnection cnn;
            cnn = new SqlConnection(_connectionString);
            string QueryStr = @"insert into Register (MobileNumber, Email, Password) values (@MobileNumber, @Email, @Password)";
            using (SqlCommand cmd = new SqlCommand(QueryStr, cnn))
            {
                cmd.Parameters.AddWithValue("MobileNumber", txtMobile.Text.Trim());
                cmd.Parameters.AddWithValue("Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("Password", txtPassword.Text.Trim());

                cnn.Open();
                Save = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            return Save;
        }
    }
}