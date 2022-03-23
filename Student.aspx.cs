using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SUsername"] == null)
            {
                Session["InvalidUsage"] = "You must first log in to view the site!";
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            Response.Redirect("ApplyScholarship.aspx");
        }

        

        protected void btnEditStudentInfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditStudent.aspx");
        }

        protected void btnStudentProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStudent.aspx");
        }
    }
}