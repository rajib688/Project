using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using DAL;


namespace MyWeb
{
    public partial class Dashborad : System.Web.UI.Page
    {
        CommonDAL objc = new CommonDAL();
        string ConnectionStr = @"Data Source = DESKTOP-K32T5PF; Initial Catalog= PersonalWeb; Integrated Security = true;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HeroSection();
                AboutSection();
                Skill();
                Person();
                CSE();
                HSC();
                SSC();
                JSC();
                DotNet();
                DigitalMarket();
                EnglishCourse();
                Excel();
                Contact();
            }
        }
        private void HeroSection()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT (FirstName+' '+LastName) AS FullName FROM UserRegistration");
            if (dt.Rows.Count > 0)
            {
                Name.InnerText = dt.Rows[0]["FullName"].ToString();
            }
        }
        private void AboutSection()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT Title, [Image], Designation, SubTitle, Birthday, Website, Phone, City, Age, Degree, Email, Developer, [Description] FROM  AboutSection");
            if (dt.Rows.Count > 0)
            {
                abTitle.InnerText = dt.Rows[0]["Title"].ToString();
                Designation.InnerText = dt.Rows[0]["Designation"].ToString();
                SubTi.InnerText = dt.Rows[0]["SubTitle"].ToString();
                Birth.InnerText = dt.Rows[0]["Birthday"].ToString();
                web.InnerText = dt.Rows[0]["Website"].ToString();
                Phn.InnerText = dt.Rows[0]["Phone"].ToString();
                Ct.InnerText = dt.Rows[0]["City"].ToString();
                Ag.InnerText = dt.Rows[0]["Age"].ToString();
                Deg.InnerText = dt.Rows[0]["Degree"].ToString();
                Emal.InnerText = dt.Rows[0]["Email"].ToString();
                Dev.InnerText = dt.Rows[0]["Developer"].ToString();
                Descr.InnerText = dt.Rows[0]["Description"].ToString();
            }
        }
        private void Skill()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT  Title, Langhtml, Langcss, Langjava, Sql, Linux, Langc#, Langc, Dotnet, photo, Windows FROM  Skill");
            if (dt.Rows.Count > 0)
            {
                STitle.InnerText = dt.Rows[0]["Title"].ToString();
                //Shtml.InnerText = dt.Rows[0]["Langhtml"].ToString();
                //Scss.InnerText = dt.Rows[0]["Langcss"].ToString();
                //Sjava.InnerText = dt.Rows[0]["Langjava"].ToString();
                //SSql.InnerText = dt.Rows[0]["Sql"].ToString();
                //Slunix.InnerText = dt.Rows[0]["Linux"].ToString();
                //Scsharp.InnerText = dt.Rows[0]["Langc#"].ToString();
                //Sc.InnerText = dt.Rows[0]["Langc"].ToString();
                //Sdotnet.InnerText = dt.Rows[0]["Dotnet"].ToString();
                //Sphoto.InnerText = dt.Rows[0]["photo"].ToString();
                //Swindows.InnerText = dt.Rows[0]["Windows"].ToString();
            }
        }
        private void Person()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT (UserRegistration.FirstName+' '+UserRegistration.LastName) AS FullName, Resume.Title, Resume.SumaryTitle, Resume.Location, Resume.PhoneNumber, Resume.Email FROM Resume Inner JOIN UserRegistration on UserRegistration.UserID = [Resume].ID");
            if (dt.Rows.Count > 0)
            {
                TitleResume.InnerText = dt.Rows[0]["Title"].ToString();
                PersonalResume.InnerText = dt.Rows[0]["FullName"].ToString();
                Titlesumary.InnerText = dt.Rows[0]["SumaryTitle"].ToString();
                Locat.InnerText = dt.Rows[0]["Location"].ToString();
                phnnmbr.InnerText = dt.Rows[0]["PhoneNumber"].ToString();
                eml.InnerText = dt.Rows[0]["Email"].ToString();
            }
        }
        private void CSE()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT Title, Session, SchoolName, Description FROM CSE");
            if (dt.Rows.Count > 0)
            {
                cse.InnerText = dt.Rows[0]["Title"].ToString();
                session.InnerText = dt.Rows[0]["Session"].ToString();
                cseloc.InnerText = dt.Rows[0]["SchoolName"].ToString();
                descriCse.InnerText = dt.Rows[0]["Description"].ToString();
            }
        }
        private void HSC()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT Title, Session, SchoolName, Description FROM HSC");
            if (dt.Rows.Count > 0)
            {
                hscTitle.InnerText = dt.Rows[0]["Title"].ToString();
                hscSession.InnerText = dt.Rows[0]["Session"].ToString();
                hscschool.InnerText = dt.Rows[0]["SchoolName"].ToString();
                hscDescription.InnerText = dt.Rows[0]["Description"].ToString();
            }
        }

        private void SSC()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT Title, Session, SchoolName, Description FROM SSC");
            if (dt.Rows.Count > 0)
            {
                sscTitle.InnerText = dt.Rows[0]["Title"].ToString();
                SscSession.InnerText = dt.Rows[0]["Session"].ToString();
                SSCschoolName.InnerText = dt.Rows[0]["SchoolName"].ToString();
                SSCDescri.InnerText = dt.Rows[0]["Description"].ToString();
            }
        }

        private void JSC()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT Title, Session, SchoolName, Description FROM JSC");
            if (dt.Rows.Count > 0)
            {
                JscTitle.InnerText = dt.Rows[0]["Title"].ToString();
                JscSession.InnerText = dt.Rows[0]["Session"].ToString();
                JscSchool.InnerText = dt.Rows[0]["SchoolName"].ToString();
                JscDescri.InnerText = dt.Rows[0]["Description"].ToString();
            }
        }

        private void DotNet()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT  Title, Session, Location, Description1st, Description2nd FROM DotNet");
            if (dt.Rows.Count > 0)
            {
                dotTitle.InnerText = dt.Rows[0]["Title"].ToString();
                DotSession.InnerText = dt.Rows[0]["Session"].ToString();
                DotLoc.InnerText = dt.Rows[0]["Location"].ToString();
                descri1st.InnerText = dt.Rows[0]["Description1st"].ToString();
                descr2nd.InnerText = dt.Rows[0]["Description2nd"].ToString();
            }
        }

        private void DigitalMarket()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT Title, Session, Location, Description1st, Description2nd, Description3rd FROM DigitalMarket");
            if (dt.Rows.Count > 0)
            {
                DmTitle.InnerText = dt.Rows[0]["Title"].ToString();
                DmSession.InnerText = dt.Rows[0]["Session"].ToString();
                DmLocat.InnerText = dt.Rows[0]["Location"].ToString();
                descrip1st.InnerText = dt.Rows[0]["Description1st"].ToString();
                descrip2nd.InnerText = dt.Rows[0]["Description2nd"].ToString();
                descrip3rd.InnerText = dt.Rows[0]["Description3rd"].ToString();
            }
        }

        private void EnglishCourse()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT Title, Session, Location, Description FROM EnglishCourse");
            if (dt.Rows.Count > 0)
            {
                AdTitle.InnerText = dt.Rows[0]["Title"].ToString();
                AdSession.InnerText = dt.Rows[0]["Session"].ToString();
                AdLocat.InnerText = dt.Rows[0]["Location"].ToString();
                AdDescrip.InnerText = dt.Rows[0]["Description"].ToString();
            }
        }

        private void Excel()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("SELECT Title, Session, Location, Description FROM MsExcel");
            if (dt.Rows.Count > 0)
            {
                ExTitle.InnerText = dt.Rows[0]["Title"].ToString();
                ExSession.InnerText = dt.Rows[0]["Session"].ToString();
                ExLocat.InnerText = dt.Rows[0]["Location"].ToString();
                Exdescr.InnerText = dt.Rows[0]["Description"].ToString();
            }
        }
        private void Contact()
        {
            DataTable dt = new DataTable();
            dt = objc.loaddt("select Title, [Location], Email, [Call] from Contact");
            if (dt.Rows.Count > 0)
            {
                ConTitle.InnerText = dt.Rows[0]["Title"].ToString();
                Location.InnerText = dt.Rows[0]["Location"].ToString();
                EmailAddre.InnerText = dt.Rows[0]["Email"].ToString();
                Callnun.InnerText = dt.Rows[0]["Call"].ToString();
            }
        }

        private void SaveContact()
        {
            int Save = 0;
            SqlConnection cnn;
            cnn = new SqlConnection(ConnectionStr);
            SqlCommand cmd;
            string SqlStr = @"insert into ContactTable
            (ContactName, ContactPhone, ContactEmail, ContactMessage, EntryDate)
            values('" + txtname.Text.Trim() + "','" + txtPhn.Text.Trim() + "','" + txtEmail.Text.Trim() + "','" + txtMessage.Text.Trim() + "',GETDATE())";
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                cnn.Open();
                cmd = new SqlCommand(SqlStr, cnn);
                sda.InsertCommand = cmd;
                Save = sda.InsertCommand.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception)
            {

            }
            if (Save > 0)
            {
                ClearField();
                MessageBox.Show("Save SuccessFully.");
            }
            else
            {
                MessageBox.Show("Your phone is duplicate");
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckFieldValue() == false)
            {
                SaveContact();
                ClearField();
            }
        }
        private void ClearField()
        {
            txtname.Text = "";
            txtPhn.Text = "";
            txtEmail.Text = "";
            txtMessage.Text = "";
        }
        private bool CheckFieldValue()
        {
            bool IsReq = false;
            if (txtname.Text == "")
            {
                IsReq = true;
                MessageBox.Show("Please enter your Name");
                txtname.Focus();
            }
            else if (txtPhn.Text == "")
            {
                IsReq = true;
                MessageBox.Show("Please enter your Phone number");
                txtPhn.Focus();
            }
            else if (txtEmail.Text == "")
            {
                IsReq = true;
                MessageBox.Show("Please enter your Email");
                txtEmail.Focus();
            }
            
            return IsReq;
        }
    }
}