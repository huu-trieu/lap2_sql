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
    public partial class Add_Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }

        protected void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            string HoTen = txtTenKH.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();
            string gioiTinh = rdlGioiTinh.SelectedValue;
            string soThich = ddlSoThich.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // Tạo kết nối tới cơ sở dữ liệu
            string connectionString = ConfigurationManager.ConnectionStrings["QL_DTDD1ConnectionString2"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Mở kết nối
                connection.Open();

                // Kiểm tra mã khách hàng đã tồn tại trong cơ sở dữ liệu hay chưa
                SqlCommand cmdCheckMaKH = new SqlCommand("SELECT COUNT(*) FROM KhachHang WHERE MaKH=@MaKH", connection);
                cmdCheckMaKH.Parameters.AddWithValue("@MaKH", maKH);
                int count = (int)cmdCheckMaKH.ExecuteScalar();
                if (count > 0)
                {
                    // Nếu mã khách hàng đã tồn tại, hiển thị thông báo "Thất bại"
                    lblThongBao.Text = "Thất bại";
                }
                else
                {
                    // Nếu mã khách hàng chưa tồn tại, thêm mới khách hàng vào cơ sở dữ liệu
                    SqlCommand cmdThemKH = new SqlCommand("INSERT INTO KhachHang(MaKH, HoTen, DienThoai, GioiTinh, SoThich, Email, MatKhau) VALUES(@MaKH, @HoTen, @DienThoai, @GioiTinh, @SoThich, @Email, @MatKhau)", connection);
                    cmdThemKH.Parameters.AddWithValue("@MaKH", maKH);
                    cmdThemKH.Parameters.AddWithValue("@HoTen", HoTen);
                    cmdThemKH.Parameters.AddWithValue("@DienThoai", dienThoai);
                    cmdThemKH.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmdThemKH.Parameters.AddWithValue("@SoThich", soThich);
                    cmdThemKH.Parameters.AddWithValue("@Email", email);
                    cmdThemKH.Parameters.AddWithValue("@MatKhau", matKhau);
                    int affectedRows = cmdThemKH.ExecuteNonQuery();

                    // Nếu thêm mới khách hàng thành công, hiển thị thông báo "Thành công"
                    if (affectedRows > 0)
                    {
                        lblThongBao.Text = "Thành công";
                    }
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi xảy ra, hiển thị thông báo lỗi
                lblThongBao.Text = "Lỗi: " + ex.Message;
            }
            finally
            {
                // Đóng kết nối sau khi hoàn thành các tác vụ
                connection.Close();
            }
        }
    
    }
}