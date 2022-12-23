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
    public partial class login : Form
    {
        connect tv_kn;
        public login()
        {
            InitializeComponent();
            tv_kn = new connect();
            if (tv_kn.Mo_KN_CSDL())
            {
                //   MessageBox.Show("Mo Dc CSDL Roi","Thông Báo!!!");
                //HienThiDL();

            }
            else
            {
                MessageBox.Show("Tieu Roi", "Thông Báo!!!");
            }

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
            MessageBox.Show("Hhhh");
        }
    }
}
