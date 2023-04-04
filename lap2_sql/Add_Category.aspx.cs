using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lap2_sql
{
    public partial class Add_Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThem_Click1(object sender, EventArgs e)
        {
            String conStr = ConfigurationManager.ConnectionStrings["QL_DTDD1ConnectionString2"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);

            con.Open();

            // kiem tra cung ten loai
            string strcmd1 = "Select count(*) from Loai where TenLoai = '" + txtTenLoai.Text + "' ";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strcmd1;
            cmd.Connection = con;

            int kt = (int)cmd.ExecuteScalar();
            if (kt == 0)
            {
                string Strcmd = "insert into Loai values('" + txtTenLoai.Text + "')";
                cmd.CommandText = Strcmd;

                // thuc thi
                int rs = cmd.ExecuteNonQuery();
                if (rs == 1)
                {
                    lblkq.Text = "Them thanh Cong!";
                }

            }
            else
            {
                lblkq.Text = "Trung Ten";
            }
            con.Close();
        }
    }
}