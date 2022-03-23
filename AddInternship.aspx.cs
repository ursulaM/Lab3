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
    public partial class AddInternship : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SID"] == null)
            {
                Session["InvalidLogin"] = "You must log in";
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
            string stud = "INSERT INTO [Internship]([CompanyID],[ContactID],[InternshipName], " +
                "[IDescription],[InternshipYear],[DateStart]) VALUES (@CID, @CtID, @Iname, @Des, @Year,@Date)";
            SqlCommand iadd = new SqlCommand(stud, cj);
            iadd.Parameters.AddWithValue("@CID", DropDownList1.SelectedValue);
            iadd.Parameters.AddWithValue("@CtID", DropDownList2.SelectedValue);
            iadd.Parameters.AddWithValue("@Iname", Nam.Text);
            iadd.Parameters.AddWithValue("@Des", Des.Text);
            iadd.Parameters.AddWithValue("@Year", Year.Text);
            iadd.Parameters.AddWithValue("@Date",Ds.Text );
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
   