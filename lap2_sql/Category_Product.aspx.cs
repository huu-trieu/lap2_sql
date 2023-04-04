using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lap2_sql
{
    public partial class Category_Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conStr = "Data Source = DESKTOP-IC7H419\\SQL  ; Initial Catalog = QL_DTDD1; Integrated Security = true";
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select Loai.TenLoai, SanPham.*  from  SanPham inner join Loai on SanPham.Maloai = Loai.MaLoai    ";

            cmd.Connection = con;

            con.Open();

            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}