using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace lap2_sql
{
    public partial class Product_Add_StoreProcedure_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "SELECT * FROM SanPham";
            gvProducts.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source = DESKTOP-IC7H419\\SQL  ; Initial Catalog = QL_DTDD1; Integrated Security = true";
            //SqlConnection con = new SqlConnection(conStr);
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters
                cmd.Parameters.AddWithValue("@TenSP", txtName.Text);
                cmd.Parameters.AddWithValue("@DuongDan", txtPath.Text);
                cmd.Parameters.AddWithValue("@Gia", txtPrice.Text);
                cmd.Parameters.AddWithValue("@MoTa", txtDescript.Text);
                cmd.Parameters.AddWithValue("@MaLoai", txtIDCat.Text);

                // Open connection and execute stored procedure
                con.Open();
                cmd.ExecuteNonQuery();
                
            }

            // Reload the gridview to show the newly added product
            SqlDataSource1.SelectCommand = "SELECT * FROM SanPham";
            gvProducts.DataBind();

            // Clear input fields
            txtName.Text = "";
            txtPath.Text = "";
            txtPrice.Text = "";
            txtDescript.Text = "";
            txtIDCat.Text = "";


            
      
        }
    }
}