using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lap2_sql
{
    public partial class Product_Manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          //  SqlDataSource1.InsertParameters["TenSP"].DefaultVale = ((TextBox)GridView1.FooterRow.FindControl("txtName")).Text;
           // SqlDataSource1.InsertParameters["DuongDan"].DefaultVale = ((TextBox)GridView1.FooterRow.FindControl("txtPath")).Text;
            //SqlDataSource1.InsertParameters["Gia"].DefaultVale = ((TextBox)GridView1.FooterRow.FindControl("txtPrice")).Text;
            //SqlDataSource1.InsertParameters["MoTa"].DefaultVale = ((TextBox)GridView1.FooterRow.FindControl("txtDescript")).Text;
            //SqlDataSource1.InsertParameters["MaLoai"].DefaultVale = ((TextBox)GridView1.FooterRow.FindControl("txtIDCat")).Text;

            //SqlDataSource1.Insert();

        }
    }
}