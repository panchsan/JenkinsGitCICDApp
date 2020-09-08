using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JenkinsGitCICDApp
{
    public partial class JenkinsTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClickMe_Click(object sender, EventArgs e)
        {
            Response.Redirect("JenkinsTest1.aspx");
        }

        protected void btnDbPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("JenkinsDBPage.aspx");
        }
    }
}