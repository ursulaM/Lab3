using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.IO;
using System.Net;
using System.Configuration;
using System.Data.SqlClient;

namespace Lab3
{
    public partial class UploadPDF : System.Web.UI.Page
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
            {
                Session["MInvalid"] = "You do not have access";
                Response.Redirect("Member?MInvalid=true");
            }
        }
      
    
        protected void Button1_Click(object sender, EventArgs e)
        {

            string fname = FileUpload1.FileName;
            string flocation = "textfiles//";
            string path = System.IO.Path.Combine(flocation, fname);
            SqlConnection cj = new SqlConnection(conn);
            string ses = Session["SID"].ToString();
            string stud = "UPDATE [Student] SET [FileName]=@FN,[FileLocation]=@FL WHERE StudentID =@SID";
            SqlCommand studentapp = new SqlCommand(stud, cj);
            studentapp.Parameters.AddWithValue("@FN", TextBox1.Text);
            studentapp.Parameters.AddWithValue("@FL", path);
            studentapp.Parameters.AddWithValue("@SID", ses);
            cj.Open();
            int g = studentapp.ExecuteNonQuery();
            if (g > 0)
            {
                FileUpload1.SaveAs(MapPath(path));
                Response.Redirect("ViewStudent.aspx");
            }
           
            

        }
    }
}