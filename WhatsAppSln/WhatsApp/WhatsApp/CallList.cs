using System;
using System.Collections.Generic;
using System.Text;

namespace WhatsApp
{
    internal class CallList
    {
        public CallList()
        {
        }

        public CallList(string name, DateTime today)
        {
            Name = name;
            Today = today;

        }

        public string Name { set; get; }

        public DateTime Today { set; get; }

    }
}
