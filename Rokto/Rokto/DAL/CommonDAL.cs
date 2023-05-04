using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace DAL
{
    public class CommonDAL
    {
        public static DropDownList Fillddl(DropDownList ddl, string Query, string textData, string valueData)
        {
            CommonDAL objCD = new CommonDAL();

            DataTable dt = new DataTable();
            dt = objCD.loaddt(Query);
            ddl.DataSource = dt;
            ddl.DataTextField = textData;
            ddl.DataValueField = valueData;
            ddl.DataBind();

            ListItem li = new ListItem("Select-----", "0");
            ddl.Items.Insert(0, li);
            return ddl;
        }
        public DataTable loaddt(string query)
        {
            DataTable dt = new DataTable();
            Database db;
            DbCommand dbcmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbcmd = db.GetSqlStringCommand(query);

            dt = db.ExecuteDataSet(dbcmd).Tables[0];
            return dt;
        }
        public string loadStr(string query)
        {
            string ret = "";
            DataTable dt = new DataTable();
            Database db;
            DbCommand dbcmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbcmd = db.GetSqlStringCommand(query);
            dt = db.ExecuteDataSet(dbcmd).Tables[0];
            if (dt.Rows.Count > 0)
            {
                ret = dt.Rows[0][0].ToString();
            }
            return ret;
        }
        ///আমি পরে এড করছি 
        public static DataTable GridViewDAL(string StoreProcedure)
        {
            DataTable dt = new DataTable();
            Database db;
            DbCommand dbCmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbCmd = db.GetStoredProcCommand(StoreProcedure);
            dt = db.ExecuteDataSet(dbCmd).Tables[0];
            return dt;
        }
    }
}
