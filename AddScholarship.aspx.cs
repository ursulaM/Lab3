using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Lab3
{
    public partial class AddScholarship : System.Web.UI.Page
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

            string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("SELECT MemberID, FirstName + LastName AS MemberName FROM Member", cn);
                cn.Open();
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "MemberName";
                DropDownList1.DataValueField = "MemberID";
                DropDownList1.DataBind();
            }

        }

        protected void StudentApp_Button(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
            SqlConnection cj = new SqlConnection(conn);
            string stud = "INSERT INTO [Scholarship]([MembershipID],[ScholarshipName],[ScholarshipYear], " +
                "[ScholarshipAmount],[ScholarshipDescription]) VALUES (@MID, @Snam, @Syear, @Sa, @Sd)";
            SqlCommand iadd = new SqlCommand(stud, cj);
            iadd.Parameters.AddWithValue("@MID", DropDownList1.SelectedValue);
            iadd.Parameters.AddWithValue("@Snam", Snam.Text);
            iadd.Parameters.AddWithValue("@Syear", Year.Text);
            iadd.Parameters.AddWithValue("@Sa", Sa.Text);
            iadd.Parameters.AddWithValue("@Sd", Sd.Text);
            cj.Open();

            int g = iadd.ExecuteNonQuery();
            if (g > 0)
            {
                Response.Redirect("Member.aspx");
            }
            else
            {
                Stuff.Text = "Did not execute";
            }
        }
    }
}
