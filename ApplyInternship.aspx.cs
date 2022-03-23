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
    public partial class ApplyInternship : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SID"] == null)
            {
                Session["InvalidLogin"] = "You must login";
                Response.Redirect("Homepage?InvalidLogin=true");
            }
            if (Session["SUsername"] == null)
            {
                Session["MInvalid"] = "You do not have access";
                Response.Redirect("Member?MInvalid=true");
            }

            string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Internship", cn);
                cn.Open();
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "InternshipName";
                DropDownList1.DataValueField = "InternshipID";
                DropDownList1.DataBind();
            }
        }

        protected void StudentApp_Button(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
            SqlConnection cj = new SqlConnection(conn);
            string stud = "INSERT INTO [InternApplicant]([StudentID],[InternshipID],[ApplicationDate], " +
                "[ApplicationDetails],[ApplicationStatus]) VALUES (@SID, @InternshipID, @Adate, @Adetails, '0')";
            SqlCommand studentapp = new SqlCommand(stud, cj);
            studentapp.Parameters.AddWithValue("@SID", Session["SID"]);
            studentapp.Parameters.AddWithValue("@InternshipID", DropDownList1.SelectedValue);
            studentapp.Parameters.AddWithValue("@ADate", HttpUtility.HtmlEncode(DateBox.Text));
            studentapp.Parameters.AddWithValue("@ADetails", HttpUtility.HtmlEncode(DetailsBox.Text));
            cj.Open();

            int g = studentapp.ExecuteNonQuery();
            if (g > 0)
            {
                Response.Redirect("ViewStudent.aspx");
            }
            else
            {
                Stuff.Text = "Did not execute";
            }
        }
    }
}
