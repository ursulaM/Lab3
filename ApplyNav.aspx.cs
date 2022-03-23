using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class ApplyNav : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AppI(object sender, EventArgs e)
        {
            Response.Redirect("ApplyInternship.aspx");
        }

        protected void AppJ(object sender, EventArgs e)
        {
            Response.Redirect("ApplyJob.aspx");
        }

        protected void AppS(object sender, EventArgs e)
        {
            Response.Redirect("ApplyScholarship.aspx");
        }
    }
}