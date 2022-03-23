//Ursula Mitchell
//Feb 22 2022
//Code behind to assign a student to an internship or scholarship


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Assign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["MUsername"] == null)
            {
                Session["InvalidUsage"] = "You must first log in to view the site!";
                Response.Redirect("Login.aspx");
            }
        }
    }
}