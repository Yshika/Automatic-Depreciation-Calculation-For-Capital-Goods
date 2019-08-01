using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace pro
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox17_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try { SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\pro\pro\App_Data\Database1.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from VendorDetails where Acount_Code_of_Assests='" + TextBox17.Text + "' and Account_Code_of_Name_of_Assests='" + TextBox18.Text + "'";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("Deleted");
                Response.Redirect("Home.aspx");
                }
            catch(Exception ex)
            {
                Response.Write(ex);
            }
            }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}