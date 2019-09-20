using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Kid
    {
        private string _name;
        private int _height;
        private int _hapiness;

        internal Kid(string name, int height, int hapiness)
        {
            _name = name;
            _height = height;
            _hapiness = hapiness;
        }
    }
}
