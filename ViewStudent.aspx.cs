using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class ViewStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SID"] == null)
            {
                Session["InvalidLogin"] = "You must login";
                Response.Redirect("Homepage?InvalidLogin=true");
            }
            if (Session["SInvalid"] != null){
                Incorrect.Text = Session["Sinvalid"].ToString();
            }
        }

        protected void btnLogOut_Click_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Homepage.aspx?loggedout=true");
        }

        protected void Apply(object sender, EventArgs e)
        {
            Response.Redirect("ApplyNav.aspx");
        }

        protected void Report(object sender, EventArgs e)
        {
            Response.Redirect("Report.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditStudentProfile.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("UploadPDF.aspx");
        }
    }
}