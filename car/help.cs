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
    class help
    {

        public int Checkper()
        {
            string code = login.ID_USER;
            int check = 1;
            if ("1" == code)
            {
                check = 1;
            }
            else if ("2" == code)
            {
                check= 2;
            }
                else
                check = 3;
            return check;
        }
    }

}
