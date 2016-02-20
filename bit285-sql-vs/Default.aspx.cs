using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.RawUrl, true); // A Down-and-dirty trick to reset the page
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        //lblSuccess.Visible = true;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        conn.Open();
        string checkuser = "SELECT count)(*) FROM UserData WHERE UserName = @username";
        int temp = 0;
        SqlCommand com = new SqlCommand(checkuser, conn);
        com.Parameters.Add(new SqlParameter("@username", txtUsername.Text.Trim() ));
        if (temp > 0)
        {
            lblSuccess.Visible = true;
            lblSuccess.Text = "User Already Exists! Try a different name.";
        }

        else
        {
            try
            {
                string insertQuery ="INSERT INTO UserData (Username, Email, Password, Country) VALUES (@username, @email, @password, @country)";
                SqlCommand com1 = new SqlCommand(insertQuery, conn);
                com1.Parameters.Add(new SqlParameter("@username", txtUsername.Text));
                com1.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
                com1.Parameters.Add(new SqlParameter("@password", txtPassword.Text));
                com1.Parameters.Add(new SqlParameter("@country", DropDownList1.SelectedItem.Text));
                com1.ExecuteNonQuery();
                Response.Redirect("Grid.aspx");

            }

            catch (Exception ex)
            {
                lblSuccess.Text = "Error " + ex.ToString();
                
            }
        }

    }
}