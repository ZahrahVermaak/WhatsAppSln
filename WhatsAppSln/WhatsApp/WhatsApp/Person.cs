using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WhatsApp
{
    internal class Person
    {

        public Person()
        {
        }

        public Person(string name, DateTime lastseen)
        {
            Name = name;
            LastSeen = lastseen;
           
        }

        public string Name { set; get; }

        public DateTime LastSeen { set; get; }

        public string Image { set; get; }

    }
}
