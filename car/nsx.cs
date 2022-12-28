using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace car
{
    public partial class nsx : Form
    {
        connect kn = new connect();
        DataTable tb = new DataTable();
        public nsx()
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
                MessageBox.Show("kết nối dữ liệu thất bại");
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }
        string str = "Data Source=.;Integrated Security = True; Initial Catalog = xeOTo";

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_diaChi.Text == "" || tb_tenNSX.Text == "" || tb_sdt.Text == "" )
            {
                MessageBox.Show("Nhập đủ thông tin!!!");
                return;
            }
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand command = con.CreateCommand();
            var image = new ImageConverter().ConvertTo(PictureBox1.Image, typeof(byte[]));
            command.Parameters.AddWithValue("@image",image);
            command.CommandText = "insert into nsx values(N'"+tb_tenNSX.Text.Trim() + "',N'"+tb_diaChi.Text.Trim()+"',"+tb_sdt.Text.Trim() + ",@image)";
            //command = new SqlCommand(str, con);
            command.ExecuteNonQuery();
            con.Close();

        }

        private void nsx_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
