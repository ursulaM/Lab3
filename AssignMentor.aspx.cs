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
    public partial class AssignMentor : System.Web.UI.Page
    {
        public string val = "";
        public string val2 = "";
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
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID, FirstName + LastName as StudentName FROM Student", cn);
              
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cn.Close();
                DropDownList1.DataSource = dt;
                DropDownList1.DataTextField = "StudentName";
                DropDownList1.DataValueField = "StudentID";
                DropDownList1.DataBind();
                cn.Close();
            }
            using (SqlConnection cn = new SqlConnection(conn))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MemberID, FirstName + LastName as MemberName FROM Member", cn);
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cn.Close();
                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "MemberName";
                DropDownList2.DataValueField = "MemberID";
                DropDownList2.DataBind();
                cn.Close();
            }

        }

      

        protected void AssignMen(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
            SqlConnection cj = new SqlConnection(conn);
            string men = "INSERT INTO [Mentorship]([MemberID],[StudentID]) VALUES (@MID, @SID)";
            SqlCommand menadd = new SqlCommand(men, cj);
            menadd.Parameters.AddWithValue("@MID", DropDownList2.SelectedValue);
            menadd.Parameters.AddWithValue("@SID", DropDownList1.SelectedValue);
           
            cj.Open();

            int g = menadd.ExecuteNonQuery();
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