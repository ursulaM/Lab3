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
    public partial class AwardJob : System.Web.UI.Page
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

        }

        protected void Award(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
            SqlConnection cj = new SqlConnection(conn);
            string stud = "INSERT INTO StudJob(JobID,StudentID)" +
                "SELECT JobID,StudentID FROM JobApplicant " +
                "WHERE ApplicationStatus = '1'";
            SqlCommand asch = new SqlCommand(stud, cj);
            cj.Open();
            int ex = asch.ExecuteNonQuery();
            if (ex > 0)
            {
                string del = "DELETE FROM JobApplicant WHERE ApplicationStatus = '1'";
                SqlCommand ascho = new SqlCommand(del, cj);
                int x = ascho.ExecuteNonQuery();
                if (x > 0)
                {
                    Response.Redirect("Member.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        
            {
                string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
                SqlConnection cj = new SqlConnection(conn);
                string delt = "DELETE FROM JobApplicant WHERE ApplicationStatus = '3'";
                SqlCommand ascho = new SqlCommand(delt, cj);
                cj.Open();
                int x = ascho.ExecuteNonQuery();
                if (x > 0)
                {
                    Response.Redirect("Member.aspx");
                }
            }
        
    }
}