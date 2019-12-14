using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_T3_SB_Custom
{
    class StringClass
    {
        private string mystring;

        public string MyString
        {
            get { return mystring; }
            set { mystring = value; }
        }

        public bool AdditionalString(string a)
        {
            if (a == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
