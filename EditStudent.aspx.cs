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
    public partial class EditStudent : System.Web.UI.Page
    {
        private string sel = "";
        string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sel = ddlstudentlist.SelectedValue;
            SqlConnection cn = new SqlConnection(conn);
            cn.Open();
            string sqlquery = ("SELECT FirstName,LastName," +
                "StudentEmail, StudentPhone, StudentGradYear, Major, StudentID FROM STUDENT WHERE StudentID = " + sel);
            SqlCommand command = new SqlCommand(sqlquery, cn);

            SqlDataReader sdr = command.ExecuteReader();
            if (sdr.Read())
            {

                TextBox1.Text = sdr.GetString(0);
                TextBox2.Text = sdr.GetString(1);
                TextBox3.Text = sdr.GetString(2);
                TextBox4.Text = sdr.GetString(3);
                TextBox5.Text = sdr.GetInt32(4).ToString();
                TextBox6.Text = sdr.GetString(5);
                HiddenField1.Value = sdr.GetInt32(6).ToString();

            }

        }

        protected void updtButton_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(conn);

            string sqlquery = ("UPDATE [Student] SET [FirstName]=@FirstName, [LastName]=@Lastname, [StudentEmail]=@Email ," +
        "[StudentPhone] = @Phone, [StudentGradYear] = @GradYear, [Major] = @Major " +
        "WHERE StudentID = @SID");
            SqlCommand command = new SqlCommand(sqlquery, cn);
            command.Parameters.AddWithValue("@FirstName", TextBox1.Text);
            command.Parameters.AddWithValue("@LastName", TextBox2.Text);
            command.Parameters.AddWithValue("@Email", TextBox3.Text);
            command.Parameters.AddWithValue("@Phone", TextBox4.Text);
            command.Parameters.AddWithValue("@GradYear", TextBox5.Text);
            command.Parameters.AddWithValue("@Major", TextBox6.Text);
            command.Parameters.AddWithValue("@SID", HiddenField1.Value);
            cn.Open();

            int g = command.ExecuteNonQuery();
            if (g > 0)
            {
                Response.Redirect("Member.aspx");
            }
        }
    }
}