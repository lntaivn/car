using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class login : Form
    {
        public static string ID_USER = "";
        connect kn;
        DataTable tb = new DataTable();

        public login()
        {
            InitializeComponent();
            kn = new connect();
            if (kn.Mo_KN_CSDL())
            {
                //   MessageBox.Show("Mo Dc CSDL Roi","Thông Báo!!!");
                //HienThiDL();

            }
            else
            {
                MessageBox.Show("Tieu Roi", "Thông Báo!!!");
            }

        }
        private string getID(string username, string pass)
        {
            string id = "";
            try
            {
                kn.Mo_KN_CSDL();
                string str = "SELECT * FROM nhanVien WHERE emailnhanvien ='" + tb_tenDangNhap.Text.Trim() + "' and password='" + tb_matKhau.Text.Trim() + "'";
                tb = kn.LayBang(str);
                if (tb != null)
                {
                    foreach (DataRow dr in tb.Rows)
                    {
                        id = dr["maPhanQuyen"].ToString();
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                kn.DongKN();
            }
            return id;
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            ID_USER = getID(tb_tenDangNhap.Text, tb_matKhau.Text);
            if (ID_USER != "")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
