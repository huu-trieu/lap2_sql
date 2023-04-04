using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lap2_sql
{
    public partial class Product_Parameter : System.Web.UI.Page
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-IC7H419\\SQL  ; Initial Catalog = QL_DTDD1; Integrated Security = true";
            SqlConnection con = new SqlConnection(connectionString);
            //string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                //string query = "SELECT* FROM SanPham WHERE TenSP LIKE '%@TenSP%' AND Gia >= @LowPrice AND Gia <= @HighPrice";
                string query = "SELECT * FROM SanPham WHERE TenSP LIKE @TenSP";
                //SELECT* FROM SanPham WHERE TenSP LIKE '%@TenSP%' AND GiaSP >= @LowPrice AND GiaSP <= @HighPrice
                //SELECT COUNT(*) FROM SanPham WHERE TenSP LIKE '%@TenSP%' AND GiaSP >= @LowPrice AND GiaSP <= @HighPrice


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TenSP", "%" + txtTimKiem.Text + "%");
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
    }
}