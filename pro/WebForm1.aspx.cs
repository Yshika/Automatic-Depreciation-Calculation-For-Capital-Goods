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
    public partial class WebForm1 : System.Web.UI.Page
    {
           
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\pro\pro\App_Data\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into VendorDetails"+ "(Acount_Code_of_Assests,Account_Code_of_Name_of_Assests,Account_code_AD_upto_31_03_2015,Name_of_Account_code_AD_upto_31_03_2015,Account_code_AD_from_1_04_2015,Name_of_Account_code_AD_from_1_04_2015,SI,Page,VR,Particulars,Party_Name,Bill_No,Bill_Date,Qty,Original_Value,AdditionsDeletions_during_year,Sale_of_Asset,Month,Assets_transferred_fromto_other_Divn,Closing_Value,Cumulative_Depreciation,Depreciation_transferred_fromto_other_divns,Assets_whose_WDV_is_eqless_than_Rs_10000_in_year,Remaining_Life,Depreciation_adjusted_in_the_year,Cumulative_depreciation_as_on,Net_Block_in_year,New_life_in_months,Months_used,Dep_new_15_16) values (@Acount_Code_of_Assests,@Account_Code_of_Name_of_Assests,@Account_code_AD_upto_31_03_2015,@Name_of_Account_code_AD_upto_31_03_2015,@Account_code_AD_from_1_04_2015,@Name_of_Account_code_AD_from_1_04_2015,@SI,@Page,@VR,@Particulars,@Party_Name,@Bill_No,@Bill_Date,@Qty,@Original_Value,@AdditionsDeletions_during_year,@Sale_of_Asset,@Month,@Assets_transferred_fromto_other_Divn,@Closing_Value,@Cumulative_Depreciation,@Depreciation_transferred_fromto_other_divns,@Assets_whose_WDV_is_eqless_than_Rs_10000_in_year,@Remaining_Life,@Depreciation_adjusted_in_the_year,@Cumulative_depreciation_as_on,@Net_Block_in_year,@New_life_in_months,@Months_used,@Dep_new_15_16)", conn);
                cmd.Parameters.AddWithValue("Acount_Code_of_Assests", TextBox23.Text);
                cmd.Parameters.AddWithValue("Account_Code_of_Name_of_Assests", TextBox24.Text);
                cmd.Parameters.AddWithValue("Account_code_AD_upto_31_03_2015", TextBox25.Text);
                cmd.Parameters.AddWithValue("Name_of_Account_code_AD_upto_31_03_2015", TextBox26.Text);
                cmd.Parameters.AddWithValue("Account_code_AD_from_1_04_2015", TextBox27.Text);
                cmd.Parameters.AddWithValue("Name_of_Account_code_AD_from_1_04_2015", TextBox28.Text);
                cmd.Parameters.AddWithValue("SI", TextBox1.Text);
                cmd.Parameters.AddWithValue("Page", TextBox4.Text);
                cmd.Parameters.AddWithValue("VR", TextBox5.Text);
                cmd.Parameters.AddWithValue("Particulars", TextBox6.Text);
                cmd.Parameters.AddWithValue("Party_Name", TextBox7.Text);
                cmd.Parameters.AddWithValue("Bill_No", TextBox8.Text);
                cmd.Parameters.AddWithValue("Bill_Date", TextBox9.Text);    
                cmd.Parameters.AddWithValue("Qty", TextBox10.Text);
                cmd.Parameters.AddWithValue("Original_Value", TextBox11.Text);
                cmd.Parameters.AddWithValue("AdditionsDeletions_during_year", TextBox12.Text);
                cmd.Parameters.AddWithValue("Sale_of_Asset", TextBox13.Text);
                cmd.Parameters.AddWithValue("Month", TextBox14.Text);
                cmd.Parameters.AddWithValue("Assets_transferred_fromto_other_Divn", TextBox15.Text);
                cmd.Parameters.AddWithValue("Closing_Value", TextBox17.Text);
                cmd.Parameters.AddWithValue("Cumulative_Depreciation", TextBox18.Text);
                cmd.Parameters.AddWithValue("Depreciation_during_year", TextBox19.Text);
                cmd.Parameters.AddWithValue("Assets_whose_WDV_is_eqless_than_Rs_10000_in_year", TextBox20.Text);
                cmd.Parameters.AddWithValue("Depreciation_transferred_fromto_other_divns", TextBox21.Text);
                cmd.Parameters.AddWithValue("Remaining_Life", TextBox22.Text);
                cmd.Parameters.AddWithValue("Depreciation_adjusted_in_the_year", TextBox29.Text);
                cmd.Parameters.AddWithValue("Cumulative_depreciation_as_on", TextBox30.Text);
                cmd.Parameters.AddWithValue("Net_Block_in_year", TextBox31.Text);
                cmd.Parameters.AddWithValue("New_life_in_months", TextBox32.Text);
                cmd.Parameters.AddWithValue("Months_used", TextBox33.Text);
                cmd.Parameters.AddWithValue("Dep_new_15_16", TextBox34.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("Home.aspx");
            }
            catch(Exception ex)
            {
                Response.Write("Error in the inserted data:" + ex);
            }
        }

        protected void TextBox15_TextChanged(object sender, EventArgs e)
        {
            TextBox17.Text = (float.Parse(TextBox11.Text) + float.Parse(TextBox12.Text) + float.Parse(TextBox15.Text)).ToString();
            
        }

        protected void TextBox11_TextChanged(object sender, EventArgs e)
        {
            TextBox17.Text = (float.Parse(TextBox11.Text)).ToString();
           
        }

        protected void TextBox12_TextChanged(object sender, EventArgs e)
        {
            TextBox17.Text = (float.Parse(TextBox11.Text) + float.Parse(TextBox12.Text)).ToString();
        }

        protected void TextBox18_TextChanged(object sender, EventArgs e)
        {
        
        }

        protected void TextBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            float b = 0;
            float a = (float.Parse(TextBox11.Text) - float.Parse(TextBox18.Text)) / float.Parse(TextBox10.Text);
            if (a <= 10000)
            {
                TextBox20.Text = (float.Parse(TextBox11.Text) - float.Parse(TextBox18.Text)).ToString();

            }
            else
            {
                TextBox20.Text = b.ToString();
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            float a = 0;
            if (float.Parse(TextBox20.Text) > 0.0)
            {
                TextBox19.Text = a.ToString();
            }
            else
            {
                if (int.Parse(TextBox22.Text) < 12)
                {
                    TextBox19.Text = (float.Parse(TextBox17.Text) - float.Parse(TextBox18.Text)).ToString();
                }
                else
                {
                    TextBox19.Text = ((float.Parse(TextBox17.Text) - float.Parse(TextBox18.Text)) / ((float.Parse(TextBox22.Text) * float.Parse(TextBox14.Text)))).ToString();
                }
            }
        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void TextBox33_TextChanged(object sender, EventArgs e)
        {
            TextBox22.Text = (int.Parse(TextBox32.Text) - int.Parse(TextBox33.Text)).ToString();
        }

        protected void TextBox29_TextChanged(object sender, EventArgs e)
        {
            TextBox30.Text = (float.Parse(TextBox19.Text) + float.Parse(TextBox20.Text)+ float.Parse(TextBox21.Text) + float.Parse(TextBox29.Text)).ToString();
        }

        protected void TextBox30_TextChanged(object sender, EventArgs e)
        {
            TextBox31.Text = (float.Parse(TextBox17.Text) - float.Parse(TextBox30.Text)).ToString();
        }

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            TextBox22.Text = (int.Parse(TextBox32.Text) - int.Parse(TextBox33.Text)).ToString();
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            TextBox30.Text = (float.Parse(TextBox19.Text) + float.Parse(TextBox20.Text) + float.Parse(TextBox21.Text) + float.Parse(TextBox29.Text)).ToString();
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            TextBox31.Text = (float.Parse(TextBox17.Text) - float.Parse(TextBox30.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //update record
            Response.Redirect("WebForm3.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //delete 
            Response.Redirect("WebForm2.aspx");
            
        }
    }
}