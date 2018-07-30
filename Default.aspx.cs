using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Exercise_01
{
    public partial class Default : System.Web.UI.Page
    {
        private static int attempts = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            btnLogin.Click += new EventHandler(this.Login);
        }

        protected void Login(Object sender, EventArgs e)
        {
            string inputLogin = txtLogin.Text;
            string inputPassword = txtPassword.Text;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"Server=DESKTOP-V4SFE6N\SQLEXPRESS;" +
                    "Database=LPMyDB;" +
                    "Trusted_Connection=true";
                conn.Open();

                string query = string.Format($"SELECT * FROM Users WHERE username='{inputLogin}' AND password='{inputPassword}'");

                SqlCommand command = new SqlCommand(query, conn);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Response.Redirect("Success.aspx");
                    }
                    else
                    {
                        if (attempts < 3)
                        {
                            Response.Write("<script> window.alert('Invalid credentials. Please try again.'); </script>");
                            attempts++;
                        }
                        else
                        {
                            Response.Redirect("Fail.aspx");
                        }
                    }
                }
            }
        }
    }
}