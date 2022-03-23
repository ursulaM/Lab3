//Ursula Mitchell and Zach Ritter


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Lab2
{
    public partial class CreateStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkAnother_Click(object sender, EventArgs e)
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtGradYear.Enabled = false;
            txtMajor.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            btnSubmit.Enabled = false;
            lnkAnother.Visible = true;

            //Making the Values go back to empty
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtGradYear.Text = "";
            txtMajor.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtEmail.Text != "" && txtPhone.Text != "" && txtGradYear.Text != "" && txtMajor.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                //Commit Values
                try
                {
                    System.Data.SqlClient.SqlConnection sc = new SqlConnection(WebConfigurationManager.ConnectionStrings["AUTH"].ConnectionString.ToString());
                    System.Data.SqlClient.SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab3"].ConnectionString.ToString());
                    lblStatus.Text = "Database Connection Successful";

                    con.Open();

                    System.Data.SqlClient.SqlCommand createStudent = new System.Data.SqlClient.SqlCommand();
                    createStudent.Connection = con;

                    //Insert Student Record

                    createStudent.CommandText = "INSERT INTO Student (FirstName, LastName, StudentEmail, StudentPhone, StudentGradYear, Major , Username) VALUES (@FName, @LName, @Email, @Phone, @GradYear, @Major, @SUsername)";
                    createStudent.Parameters.Add(new SqlParameter("@FName", HttpUtility.HtmlEncode( txtFirstName.Text)));
                    createStudent.Parameters.Add(new SqlParameter("@LName", HttpUtility.HtmlEncode(txtLastName.Text)));
                    createStudent.Parameters.Add(new SqlParameter("@Email", HttpUtility.HtmlEncode(txtEmail.Text)));
                    createStudent.Parameters.Add(new SqlParameter("@Phone", HttpUtility.HtmlEncode(txtPhone.Text)));
                    createStudent.Parameters.Add(new SqlParameter("@GradYear", HttpUtility.HtmlEncode(txtGradYear.Text)));
                    createStudent.Parameters.Add(new SqlParameter("@Major", HttpUtility.HtmlEncode(txtMajor.Text)));
                    createStudent.Parameters.Add(new SqlParameter("@SUsername", HttpUtility.HtmlEncode(txtUsername.Text)));
                    createStudent.ExecuteNonQuery();


                    sc.Open();

                    System.Data.SqlClient.SqlCommand createUser = new System.Data.SqlClient.SqlCommand();
                    createUser.Connection = sc;
                    //Insert User record and connect to user
                    createUser.CommandText = "INSERT INTO Person (Username, Email, Approved) VALUES (@Username, @Email, '0')";
                    createUser.Parameters.Add(new SqlParameter("@Username", HttpUtility.HtmlEncode(txtUsername.Text)));
                    createUser.Parameters.Add(new SqlParameter("@Email", HttpUtility.HtmlEncode(txtEmail.Text)));
                    createUser.ExecuteNonQuery();

                    System.Data.SqlClient.SqlCommand setPass = new System.Data.SqlClient.SqlCommand();
                    setPass.Connection = sc;
                    setPass.CommandText = "INSERT INTO Pass (UserID, Username, PasswordHash) VALUES ((SELECT MAX(UserID) FROM Person), @Username, @Password)";
                    setPass.Parameters.Add(new SqlParameter("@Username", HttpUtility.HtmlEncode(txtUsername.Text)));
                    setPass.Parameters.Add(new SqlParameter("@Password", HttpUtility.HtmlEncode(PasswordHash.HashPassword(txtPassword.Text))));
                    setPass.ExecuteNonQuery();


                   

                    con.Close();
                    sc.Close();

                    lblStatus.Text = "User Committed!";
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPhone.Enabled = false;
                    txtGradYear.Enabled = false;
                    txtMajor.Enabled = false;
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    btnSubmit.Enabled = false;
                    lnkAnother.Visible = true;
                }
                catch
                {
                    lblStatus.Text = "Database Error - User not committed.";
                }
            }

            else
                lblStatus.Text = "Fill all fields.";

            
        }


    


        protected void lnkLogin_Click(object sender, EventArgs e)
        {
            {
                Response.Redirect("Homepage.aspx", false);
            }
        }
    }
}