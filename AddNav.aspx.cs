using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class AddNav : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddM(object sender, EventArgs e)
        {
            Response.Redirect("AddMember.apsx");
        }

        protected void AddSc(object sender, EventArgs e)
        {
            Response.Redirect("AddScholarship.apsx");
        }

        protected void AddI(object sender, EventArgs e)
        {
            Response.Redirect("AddInternship.apsx");
        }

        protected void AddJ(object sender, EventArgs e)
        {
            Response.Redirect("AddJob.apsx");
        }
    }
}