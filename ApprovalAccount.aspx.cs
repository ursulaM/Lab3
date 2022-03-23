using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Lab2
{
    public partial class ApprovalAccount : System.Web.UI.Page
    {

        string strConnection = ConfigurationManager.ConnectionStrings
                    ["AUTH"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SID"] == null)
            {
                Session["InvalidLogin"] = "You must login";
                Response.Redirect("Homepage.aspx");
            }
            if (Session["Admin"] == null)
            {
                Session["MUsername"] = "You do not have access";
                Response.Redirect("Member.aspx");
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member.aspx");

        }
    }
}