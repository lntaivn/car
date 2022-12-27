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
            str = "SELECT * FROM phanquyen";
            //DataTable bang = new DataTable();
            tb = kn.LayBang(str);

            cb_chucVu.DataSource = tb;
            cb_chucVu.DisplayMember = "tenphanQuyen";
            cb_chucVu.ValueMember = "maphanQuyen";
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
            if (tb_diaChi.Text == "" || tb_tenNhanVien.Text == ""||cb_gioiTinh.Text =="" ||  tb_sdt.Text == "" || tb_email.Text == "" || tb_matKhau.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin!!!");
                return;
            }
            if (tb_sdt.Text.Trim().Length > 10 )
            {
                MessageBox.Show("Số điện thoại sai");
                tb_sdt.Focus();
                return;
            }
            try
            {
                
                string query = "insert into nhanvien values ("+ cb_chucVu.SelectedValue + ",N'"+tb_tenNhanVien.Text.Trim() + "','"+ns_nhanVien.Value+"',N'"+ cb_gioiTinh.Text.Trim()+"',"+tb_sdt.Text.Trim() + ",'"+tb_matKhau.Text.Trim() +"','"+tb_email.Text.Trim() +"',N'"+tb_diaChi.Text.Trim() +"')";
                kn.CapNhatDL(query);
                HienThiDL();
                
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tb_diaChi.Text == "" || tb_tenNhanVien.Text == "" || cb_gioiTinh.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" || tb_matKhau.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin!!!");
                return;
            }

            string str = "delete from nhanvien where emailnhanvien='" + tb_email.Text.Trim()+"'";
            kn.CapNhatDL(str);
            HienThiDL();
        }

        private void btn_troLai_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.ShowDialog();
        }

        private void NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát", "Thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
