using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Drawing;

namespace Lab3
{
    public partial class Homepage : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblIncorrectLogin.ForeColor = Color.Red;
            if (Session["InvalidLogin"] != null)
            {
                lblIncorrectLogin.Text = Session["InvalidLogin"].ToString();
            }
            //Checking for a query existing as logged out
            if (Request.QueryString.Get("loggedout") == "true")
            {
                lblIncorrectLogin.ForeColor = Color.Green;
                lblIncorrectLogin.Text = "User Successfully Logged Out!";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                System.Data.SqlClient.SqlConnection sc = new SqlConnection(WebConfigurationManager.ConnectionStrings["AUTH"].ConnectionString.ToString());
                lblStatus.Text = "Database Connection Successful";

                sc.Open();
                System.Data.SqlClient.SqlCommand findPass = new System.Data.SqlClient.SqlCommand();
                findPass.Connection = sc;

                // SELECT PASSWORD STRING WHERE THE ENTERED USERNAME MATCHES
                findPass.CommandText = "SELECT PasswordHash FROM Pass WHERE Username = @Username";
                findPass.Parameters.Add(new SqlParameter("@Username", txtUsername.Text));

                SqlDataReader reader = findPass.ExecuteReader(); // create a reader


                if (reader.HasRows) // if the username exists, it will continue
                {
                    while (reader.Read()) // this will read the single record that matches the entered username
                    {
                        string storedHash = reader["PasswordHash"].ToString(); // store the database password into this variable

                        if (PasswordHash.ValidatePassword(txtPassword.Text, storedHash)) // if the entered password matches what is stored, it will show success
                        {
                            //Seeing the user logging has the approval by the admin by seeing if they have the numer 1 in the Person table
                            string conn = ConfigurationManager.ConnectionStrings["AUTH"].ConnectionString;
                            string con = ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString;


                            //Creating a session variable to tie to the student and member table
                            string sqlQry = "SELECT COUNT(1) FROM [Student] WHERE [Username]=@SUsername";
                            string sqlQry1 = "SELECT COUNT(1) FROM [Member] WHERE [Username]= @MUsername";

                            SqlConnection cj = new SqlConnection(conn);
                            SqlConnection sm = new SqlConnection(con);
                            cj.Open();
                            sm.Open();

                            SqlCommand stud = new SqlCommand(sqlQry, sm);
                            stud.Parameters.AddWithValue("@SUsername", txtUsername.Text);

                            SqlCommand memb = new SqlCommand(sqlQry1, sm);
                            memb.Parameters.AddWithValue("@MUsername", txtUsername.Text);

                            //Stored Procedures
                            string jk = "Lab3StoredProcedures";
                            SqlCommand approv = new SqlCommand(jk, cj);
                            approv.CommandType = CommandType.StoredProcedure;
                            
                            approv.Parameters.AddWithValue("@Username", txtUsername.Text.ToString());

                            int count = Convert.ToInt32(approv.ExecuteScalar());
                            int count1 = Convert.ToInt32(stud.ExecuteScalar());
                            int count2 = Convert.ToInt32(memb.ExecuteScalar());


                            if (count > 0)
                            {
                                lblStatus.Text = "Success!";
                                btnLogin.Enabled = false;
                                txtUsername.Enabled = false;
                                txtPassword.Enabled = false;
                                if (count1 > 0)
                                {
                                    Session["SUserName"] = txtUsername.Text;
                                    Session["SID"] = count1;
                                    Response.Redirect("ViewStudent.aspx");
                                }
                                else if (count2 > 0)
                                {
                                    Session["MUserName"] = txtUsername.Text;
                                    Session["SID"] = count2;
                                    Response.Redirect("Member.aspx");

                                }
                            }
                            else
                            {
                                lblStatus.Text = "Account has not been approved";
                            }
                            //cj.Close();

                        }
                        else
                            lblStatus.Text = "Password is wrong.";
                    }
                }
                else // if the username doesn't exist, it will show failure
                    lblStatus.Text = "Login failed.";

                sc.Close();
            }
            catch
            {
                lblStatus.Text = "Database Error.";
            }
        }


        protected void btnCreateStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateStudent.aspx");

        }
    }
}