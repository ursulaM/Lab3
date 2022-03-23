using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using System.IO;
using System.Net;

namespace Lab3
{
    public partial class EditStudentProfile : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["SID"] == null)
            {
                Session["InvalidLogin"] = "You must login";
                Response.Redirect("Homepage?InvalidLogin=true");
            }
            if (Session["SUsername"] == null)
            { Session["MInvalid"] = "You do not have access";
                Response.Redirect("Member?MInvalid=true");
            }
            if (!Page.IsPostBack)
            {
                showData();
            }
        }
            protected void showData()
            {
                string sel = Session["SID"].ToString();
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


        
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int rowindex = ((GridViewRow)((sender as Control)).NamingContainer).RowIndex;
            string flocation = GridView1.Rows[rowindex].Cells[2].Text;
            string FilePath = Server.MapPath("~/" + flocation);
            WebClient User = new WebClient();
            Byte[] FileBuffer = User.DownloadData(FilePath);
            if (FileBuffer != null)
            {
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-length", FileBuffer.Length.ToString());
                Response.BinaryWrite(FileBuffer);
            }
        }

        protected void updtButton_Click(object sender, EventArgs e)
        {
            string sel = Session["SUsername"].ToString();
            SqlConnection cn = new SqlConnection(conn);
            string sqlquery = ("UPDATE [Student] SET [FirstName]=@FirstName, [LastName]=@Lastname, [StudentEmail]=@Email ," +
        "[StudentPhone] = @Phone, [StudentGradYear] = @GradYear, [Major] = @Major " +
        "WHERE SUsername = @Susername");
            SqlCommand command = new SqlCommand(sqlquery, cn);
            command.Parameters.AddWithValue("@FirstName", HttpUtility.HtmlEncode(TextBox1.Text));
            command.Parameters.AddWithValue("@LastName", HttpUtility.HtmlEncode(TextBox2.Text));
            command.Parameters.AddWithValue("@Email", HttpUtility.HtmlEncode(TextBox3.Text));
            command.Parameters.AddWithValue("@Phone", HttpUtility.HtmlEncode(TextBox4.Text));
            command.Parameters.AddWithValue("@GradYear", HttpUtility.HtmlEncode(TextBox5.Text));
            command.Parameters.AddWithValue("@Major", HttpUtility.HtmlEncode(TextBox6.Text));
            command.Parameters.AddWithValue("@Susername", HttpUtility.HtmlEncode(sel));
            cn.Open();
            int g = command.ExecuteNonQuery();
            if (g > 0)
            {
                Response.Redirect("HomeNav.aspx");
            }
        }








    }

     
   

      
    }
    
