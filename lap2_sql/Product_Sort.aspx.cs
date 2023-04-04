using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace lap2_sql
{
    public partial class Product_Sort : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conStr = "Data Source = DESKTOP-IC7H419\\SQL  ; Initial Catalog = QL_DTDD1; Integrated Security = true";
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from SanPham ";

            cmd.Connection = con;

            con.Open();

            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source = DESKTOP-IC7H419\\SQL  ; Initial Catalog = QL_DTDD1; Integrated Security = true";
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand();
            string selectedTenSP = ddlSortName.SelectedValue;
            string selectedPrice = ddlSortPrice.SelectedValue;

            if (String.Equals(selectedTenSP, "A-Z", StringComparison.OrdinalIgnoreCase) &&
                String.Equals(selectedPrice, "Từ thấp đến cao", StringComparison.OrdinalIgnoreCase))
            {
                cmd.CommandText = "select * from SanPham order by TenSP ASC, Gia ASC ";
            }
            else
                 if (String.Equals(selectedTenSP, "A-Z", StringComparison.OrdinalIgnoreCase) &&
                String.Equals(selectedPrice, "Từ cao đến thấp", StringComparison.OrdinalIgnoreCase))
            {
                cmd.CommandText = "select * from SanPham order by TenSP ASC, Gia DESC ";
            }
            
            else 
                if (String.Equals(selectedTenSP, "Z-A", StringComparison.OrdinalIgnoreCase) &&
                String.Equals(selectedPrice, "Từ thấp đến cao", StringComparison.OrdinalIgnoreCase))
            {
                cmd.CommandText = "select * from SanPham order by TenSP DESC, Gia ASC ";
            }
            else
            {
                cmd.CommandText = "select * from SanPham order by TenSP DESC, Gia DESC ";
            }

            cmd.Connection = con;

            con.Open();

            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }    
}