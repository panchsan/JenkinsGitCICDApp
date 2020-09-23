using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JenkinsGitCICDApp
{
    public partial class JenkinsTest1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            int fsnumbermber = Convert.ToInt32(TextBox1.Text);
            int Sconumbermber = Convert.ToInt32(TextBox2.Text);
            int result = fsnumbermber + Sconumbermber;
            TextBox3.Text = result.ToString();

        }
    }
}