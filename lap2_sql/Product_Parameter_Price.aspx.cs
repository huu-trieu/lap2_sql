using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lap2_sql
{
    public partial class Product_Parameter_Price : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-IC7H419\\SQL  ; Initial Catalog = QL_DTDD1; Integrated Security = true";
            SqlConnection con = new SqlConnection(connectionString);



            //string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM SanPham";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                GridView2.DataSource = table;
                GridView2.DataBind();
                int count = table.Rows.Count;
                lblResult1.Text = "Tìm thấy " + count + " sản phẩm";
                Session["count"] = count;
                con.Close();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string tenSP = txtTenSp.Text.Trim();
            string lowPrice = txtLowPrice.Text.Trim();
            string heightPrice = txtHeightPrice.Text.Trim();

            string connectionString = "Data Source = DESKTOP-IC7H419\\SQL  ; Initial Catalog = QL_DTDD1; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            {
                string query = "SELECT * FROM SanPham WHERE TenSP LIKE @TenSP AND Gia >= @LowPrice AND Gia <= @HeightPrice";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenSP", "%" + tenSP + "%");
                command.Parameters.AddWithValue("@LowPrice", lowPrice);
                command.Parameters.AddWithValue("@HeightPrice", heightPrice);
                connection.Open();
                /*
               int count = (int)command.ExecuteScalar();
                   Session["count"] = count;
                     SqlDataReader reader = command.ExecuteReader();
                     GridView2.DataSource = reader;
                     GridView2.DataBind();
                    reader.Close();
                     lblResult1.Text = "Tìm thấy " + count + " sản phẩm."; */
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                GridView2.DataSource = table;
                GridView2.DataBind();
                int count = table.Rows.Count;
                lblResult1.Text = "Tìm thấy " + count + " sản phẩm";
                Session["count"] = count;
                connection.Close();
            }
        }
    }
}