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
    public partial class MainForm : Form
    {
        help h = new help();
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (h.Checkper() != 3) { }
            else
            {
                login login = new login();  
                login.ShowDialog(); 
            }

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void btn_nhanVien_Click(object sender, EventArgs e)
        {
            if (h.Checkper()==2)
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.Show();
            }
            else
                MessageBox.Show("Chức năng này không giành cho bạn !");
           
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            login.ID_USER = "";
            
        }

        private void btn_NSX_Click(object sender, EventArgs e)
        {

        }
    }
}
