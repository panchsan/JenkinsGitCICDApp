using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JenkinsGitCICDApp
{
    public partial class JenkinsDBPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_all_employess";
            cmd.Connection = con;
            try
            {
                con.Open();
                gvEmployee.EmptyDataText = "No Records Found";
                gvEmployee.DataSource = cmd.ExecuteReader();
                gvEmployee.DataBind();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}