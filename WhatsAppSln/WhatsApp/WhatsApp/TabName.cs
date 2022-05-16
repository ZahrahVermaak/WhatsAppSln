using System;
using System.Collections.Generic;
using System.Text;

namespace WhatsApp
{
    internal class TabName
    {
        public TabName()
        {
            ;
        }

        public TabName(string name)
        {
            Name = name; 
        }

        public string Name { set; get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
