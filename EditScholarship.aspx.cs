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
    public partial class EditScholarship : System.Web.UI.Page
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
            sel = ddlsclist.SelectedValue;
            SqlConnection cn = new SqlConnection(conn);
            cn.Open();
            string sqlquery = ("SELECT " +
                "ScholarshipName, ScholarshipYear, ScholarshipAmount,ScholarshipDescription , ScholarshipID FROM Scholarship WHERE ScholarshipID = " + sel);
            SqlCommand command = new SqlCommand(sqlquery, cn);

            SqlDataReader sdr = command.ExecuteReader();
            if (sdr.Read())
            {

                TextBox1.Text = sdr.GetString(0);
                TextBox2.Text = sdr.GetString(1);
                TextBox3.Text = sdr.GetDouble(2).ToString();
                TextBox4.Text = sdr.GetString(3);
                HiddenField1.Value = sdr.GetInt32(4).ToString();

            }

        }

        protected void updtButton_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(conn);

            string sqlquery = ("UPDATE [Scholarship] SET [ScholarshipName]=@Name, [ScholarshipYear]=@Y, [ScholarshipAmount]=@A ," +
        "[ScholarshipDescription] = @D " +
        "WHERE ScholarshipID = @SID");
            SqlCommand command = new SqlCommand(sqlquery, cn);
            command.Parameters.AddWithValue("@Name", TextBox1.Text);
            command.Parameters.AddWithValue("@Y", TextBox2.Text);
            command.Parameters.AddWithValue("@A", TextBox3.Text);
            command.Parameters.AddWithValue("@D", TextBox4.Text);
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