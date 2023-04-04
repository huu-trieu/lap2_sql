using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lap2_sql
{
    public partial class Product_ByCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryID = int.Parse(ddlCategory.SelectedValue);

            string conStr = "Data Source=DESKTOP-IC7H419\\SQL;Initial Catalog=QL_DTDD1;Integrated Security=true";
            string query = "";

            if (categoryID == 0)
            {
                query = "SELECT * FROM SanPham";
            }
            else
            {
                query = "SELECT * FROM  SanPham WHERE MaLoai = " + categoryID;
            }

            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}