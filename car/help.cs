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

        public Boolean Checkper()
        {
            string code = login.ID_USER;
            Boolean check = false;
            if ("1" == code)
            {
                check = false;
            }
            else if ("2" == code)
            {
                check= true;
            }
            return check;
        }
    }

}
