using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace Lab3
{
    public partial class StudentSearch : System.Web.UI.Page
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
            sel = TextBox7.Text;
            string sel2 = TextBox8.Text;
            SqlConnection cn = new SqlConnection(conn);
            cn.Open();
            string sqlquery = ("SELECT FirstName,LastName," +
                "StudentEmail, StudentPhone, StudentGradYear, Major, StudentID FROM STUDENT WHERE LastName = '" + sel +"' AND FirstName = '" + sel2 +"'");
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
    }
}

    
