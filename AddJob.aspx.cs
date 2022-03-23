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
    public partial class AddJob : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Company", cn);
                cn.Open();
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "CompanyName";
                DropDownList1.DataValueField = "CompanyID";
                DropDownList1.DataBind();
            }

            using (SqlConnection cn = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Contact", cn);
                cn.Open();
                DropDownList2.DataSource = cmd.ExecuteReader();
                DropDownList2.DataTextField = "ContactName";
                DropDownList2.DataValueField = "ContactID";
                DropDownList2.DataBind();
            }
        }

        protected void StudentApp_Button(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
            SqlConnection cj = new SqlConnection(conn);
            string stud = "INSERT INTO [Job]([CompanyID],[ContactID],[JName], " +
                "[Salary],[Location]) VALUES (@CID, @CtID, @Jname, @Sal, @Loco)";
            SqlCommand studentapp = new SqlCommand(stud, cj);
            studentapp.Parameters.AddWithValue("@CID", DropDownList1.SelectedValue);
            studentapp.Parameters.AddWithValue("@CtID", DropDownList2.SelectedValue);
            studentapp.Parameters.AddWithValue("@Jname", Nam.Text);
            studentapp.Parameters.AddWithValue("@Sal", Sal.Text);
            studentapp.Parameters.AddWithValue("@Loco", Loco.Text);
            cj.Open();

            int g = studentapp.ExecuteNonQuery();
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