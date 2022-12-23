using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
namespace car
{
    class connect
    {
        SqlConnection kn;
        SqlCommand Lenh;
        public connect()
        {
            string str = "Data Source=.;Integrated Security = True; Initial Catalog = xeOTo";
            kn = new SqlConnection();
            kn.ConnectionString = str;

        }
        public connect(string str)
        {

            kn = new SqlConnection();
            kn.ConnectionString = str;

        }
        public bool Mo_KN_CSDL()
        {
            try
            {
                kn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void CapNhatDL(string str)
        {
            try
            {
                Lenh = new SqlCommand(str, kn);
                Lenh.ExecuteNonQuery();

            }
            catch { }
        }
        public DataTable LayBang(string str)
        {
            SqlDataAdapter bodocghi = new SqlDataAdapter(str, kn);
            DataTable bang = new DataTable();
            bodocghi.Fill(bang);
            return bang;

        }
        public void DongKN()
        {
            kn.Close();
        }

    }
}
