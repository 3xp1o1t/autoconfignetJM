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
       

        public string RandomVlanName(int name_length)
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghihklmnopqrstuvwxyz";
            Random r = new Random();
            string output = "";
            for (int i = 0; i < name_length; i++)
            {
                output += letters[index: r.Next(0, letters.Length)];
            }
            return output;
        }

        public bool SetCustomNVlanName(string name, List<string> names)
        {
            if (names.Contains(name))
            {
                return false;    
            }
            else
            {
                names.Add(name);
                return true;
            }
        }
    }
}
