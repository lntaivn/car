using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class NhanVien : Form
    {
        connect kn = new connect();
        DataTable tb = new DataTable();
        public NhanVien()
        {
            InitializeComponent();
            kn = new connect();
            if (kn.Mo_KN_CSDL())
            {
                //   MessageBox.Show("Mo Dc CSDL Roi","Thông Báo!!!");
                HienThiDL();

            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }

        }
        void HienThiDL()
        {
          string str;
          //  str = "SELECT * FROM nhanvien";
           // DataTable bang = new DataTable();
           // tb = kn.LayBang(str);
            //dgvhung.DataSource = tb;
            //dgvLoaHang.DataSource = bang;
            //cb_gioiTinh.DataSource = bang;
            //cb_gioiTinh.DisplayMember = "maPhanQuyen";
            //cb_gioiTinh.ValueMember = "maPhanQuyen";
            str = "select maNhanVien as 'Mã Nhân Viên', tenNhanVien as 'Tên Nhân Viên', diachiNhanVien as 'Địa Chỉ', sdtNhanVien as 'SĐT', nhanvien.maphanquyen as 'Chức Vụ'from nhanvien,phanquyen where phanquyen.maphanquyen= nhanvien.maphanquyen";
            //str = "select a.MANHANVIEN , B.TENPHANQUYEN FROM NHANVIEN AS a ,PHANQUYEN AS b where a.MAPHANQUYEN = b.MAPHANQUYEN;";
            tb = kn.LayBang(str);
            list_nhanVien.DataSource = tb;
            list_nhanVien.Columns[0].HeaderText = "MÃ NHÂN VIÊN";
            list_nhanVien.Columns[1].HeaderText = "TÊN PHÂN QUYỀN";
            list_nhanVien.AllowUserToAddRows = false;
            list_nhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
            //saaaaaa
            
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienThiDL();
        }

        private void tb_tenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_std_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_diaChi.Text == "" || tb_tenNhanVien.Text == "" || tb_std.Text == "" || tb_tenDangNhap.Text == "" || tb_matKhau.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin!!!");
                return;
            }
            if (tb_std.Text.Trim().Length > 10 )
            {
                MessageBox.Show("Số điện thoại sai");
                tb_std.Focus();
                return;
            }
            try
            {
                kn.Mo_KN_CSDL();
                //string query = "insert into nhanvien values ("+tb_tenNhanVien.Text+","++")";
                kn.DongKN();
            }
            catch
            {

            }
        }

        private void cb_gioi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_nhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_chucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }
    }
}
