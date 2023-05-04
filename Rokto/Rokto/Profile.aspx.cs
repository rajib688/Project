using DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Rokto
{
    public partial class Profile : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CommonDAL.Fillddl(ddlbloodgroup, "SELECT BloodGroupId, BloodGroupName FROM BloodGroup ORDER BY BloodGroupName", "BloodGroupName", "BloodGroupId");
            }
        }
        private int Save()
        {
            int Save = 0;
            SqlConnection cnnt;
            cnnt = new SqlConnection(strcon);
            string QueryStr = @"Insert into BasicInfo (Name, BloodGroupId, Gender, DateOfBirth, NationalIDNumber, PresentAddress,
            PresentDistrict, PermanentAddress, PermanentDistrict) Values(@Name, @BloodGroupId, @Gender, @DateOfBirth, @NationalIDNumber, 
            @PresentAddress, @PresentDistrict, @PermanentAddress, @PermanentDistrict)";
            using(SqlCommand cmd = new SqlCommand(QueryStr, cnnt))
            {
                cmd.Parameters.AddWithValue("Name", txtName.Text);
                cmd.Parameters.AddWithValue("BloodGroupId", ddlbloodgroup.SelectedValue);
                cmd.Parameters.AddWithValue("Gender", ddlGender.SelectedValue);
                cmd.Parameters.AddWithValue("DateOfBirth", txtDateOfBirth.Text);
                cmd.Parameters.AddWithValue("NationalIDNumber", txtNID.Text);
                cmd.Parameters.AddWithValue("PresentAddress", txtPresentAddress.Text);
                cmd.Parameters.AddWithValue("PresentDistrict", ddlPresentDistrict.Text);
                cmd.Parameters.AddWithValue("PermanentAddress", txtpermanentAddress.Text);
                cmd.Parameters.AddWithValue("PermanentDistrict", ddlPermanentDistrict.Text);

                cnnt.Open();
                Save = cmd.ExecuteNonQuery();
                cnnt.Close();
            }
            return Save;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int Saves = Save();
            if (Saves > 0)
            {
                MessageBox.Show("Successfully Save");
            }
            else
            {
                MessageBox.Show("Save Fail");
            }
        }
    }
}