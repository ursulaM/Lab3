using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class EditNav : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EditS(object sender, EventArgs e)
        {
            Response.Redirect("EditStudent.aspx");
        }

        protected void EditM(object sender, EventArgs e)
        {
            Response.Redirect("EditMember.aspx");
        }

        protected void EditSc(object sender, EventArgs e)
        {
            Response.Redirect("EditScholarship.aspx");
        }

        protected void EditI(object sender, EventArgs e)
        {
            Response.Redirect("EditInternship.aspx");
        }

        protected void EditJ(object sender, EventArgs e)
        {
            Response.Redirect("EditJob.aspx");
        }
    }
}