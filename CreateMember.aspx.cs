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
    public partial class CreateMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtEmail.Text != "" && txtPhone.Text != "" && txtGradYear.Text != "" && txtTitle.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                //Commit Values
                try
                {
                    System.Data.SqlClient.SqlConnection sc = new SqlConnection(WebConfigurationManager.ConnectionStrings["AUTH"].ConnectionString.ToString());
                    System.Data.SqlClient.SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab3"].ConnectionString.ToString());

                    lblStatus.Text = "Database Connection Successful";

                    con.Open();
                    System.Data.SqlClient.SqlCommand createMember = new System.Data.SqlClient.SqlCommand();
                    createMember.Connection = con;

                    //Insert User into the Mmeber Record

                    createMember.CommandText = "INSERT INTO Member (FirstName, LastName, EmailAddress, PhoneNumber, GraduationYear, Title, Username) VALUES (@FName, @LName, @Email, @Phone, @GradYear, @Title, @MUsername)";
                    createMember.Parameters.Add(new SqlParameter("@FName", txtFirstName.Text));
                    createMember.Parameters.Add(new SqlParameter("@LName", txtLastName.Text));
                    createMember.Parameters.Add(new SqlParameter("@Email", txtEmail.Text));
                    createMember.Parameters.Add(new SqlParameter("@Phone", txtPhone.Text));
                    createMember.Parameters.Add(new SqlParameter("@GradYear", txtGradYear.Text));
                    createMember.Parameters.Add(new SqlParameter("@Title", txtTitle.Text));
                    createMember.Parameters.Add(new SqlParameter("@MUsername", txtUsername.Text));
                    createMember.ExecuteNonQuery();

                    //con.Close();
                    sc.Open();

                    //Insert User into Person Record
                    System.Data.SqlClient.SqlCommand createPerson = new System.Data.SqlClient.SqlCommand();
                    createPerson.Connection = sc;
                    createPerson.CommandText = createPerson.CommandText = "INSERT INTO Person ( Email, Username, Approved) VALUES ( @Email, @Username, '0')";
                    createPerson.Parameters.Add(new SqlParameter("@Email", txtEmail.Text));
                    createPerson.Parameters.Add(new SqlParameter("@Username", txtUsername.Text));
                    createPerson.ExecuteNonQuery();




                    System.Data.SqlClient.SqlCommand setPass = new System.Data.SqlClient.SqlCommand();
                    setPass.Connection = sc;
                    //Insert Password record and connect to user
                    setPass.CommandText = "INSERT INTO Pass (UserID, Username, PasswordHash) VALUES (( SELECT MAX(UserID) FROM Person), @Username, @Password)";
                    setPass.Parameters.Add(new SqlParameter("@Username", txtUsername.Text));
                    setPass.Parameters.Add(new SqlParameter("@Password", PasswordHash.HashPassword(txtPassword.Text)));
                    setPass.ExecuteNonQuery();



                    sc.Close();

                    lblStatus.Text = "User Committed!";
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPhone.Enabled = false;
                    txtGradYear.Enabled = false;
                    txtTitle.Enabled = false;
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

        protected void lnkAnother_Click(object sender, EventArgs e)
        {

            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtGradYear.Enabled = false;
            txtTitle.Enabled = false;
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
            txtTitle.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}