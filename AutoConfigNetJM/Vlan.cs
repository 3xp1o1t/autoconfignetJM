using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConfigNetJM
{
    class Vlan
    {
        public bool AddVlanToList(int number, System.Windows.Forms.ListBox lb)
        {
            if(lb.Items.Contains("vlan " + number))
            {
                return false;
            }
            else
            {
                lb.Items.Add("vlan " + number);
                return true;
            }                        
        }
    }
}
