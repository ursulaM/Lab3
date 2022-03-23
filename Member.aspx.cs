//Ursula Mitchell
//Feb 22 2022
//This is the homepage for members



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Drawing;
using System.Configuration;
namespace Lab3
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SID"] == null)
            {
                Session["InvalidLogin"] = "You must login";
                Response.Redirect("Homepage?InvalidLogin=true");
            }
            if (Session["MUsername"] == null)
            {
                Session["SInvalid"] = "You do not have access";
                Response.Redirect("ViewStudent?SInvalid=true");
            }
            if (Session["MInvalid"] != null)
            {
                Incorrect.Text = Session["MInvalid"].ToString();
            }
        }


        protected void btnAdd(object sender, EventArgs e)
        {
            Response.Redirect("AddNav.aspx");
        }

        protected void btnEdit(object sender, EventArgs e)
        {
            Response.Redirect("EditNav.aspx");
        }

        protected void SIJ(object sender, EventArgs e)
        {
            Response.Redirect("AwardNav.aspx");
        }

        protected void btnLogOut_Click_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Homepage.aspx?loggedout=true");
        }

        protected void EPro(object sender, EventArgs e)
        {
            Response.Redirect("EditMemberProfile.aspx");
        }

        protected void AMem(object sender, EventArgs e)
        {
            Response.Redirect("AssignMentor.aspx");
        }

        protected void Report(object sender, EventArgs e)
        {
            Response.Redirect("Report.aspx");
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentSearch.aspx");
        }

        protected void btnCreateMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateMember.aspx");
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
            string sqlQry1 = "SELECT COUNT(1) FROM [Member] WHERE [MemberID]=MemberID AND [Username]='Admin'";
            SqlConnection sm = new SqlConnection(conn);
            sm.Open();
            SqlCommand memb = new SqlCommand(sqlQry1, sm);
            int count2 = Convert.ToInt32(memb.ExecuteScalar());
            if (count2 == 1)
            {
                Session["Admin"] = count2;
                Response.Redirect("ApprovalAccount.aspx");
            }
            else
            {

            }

        }
    }
}