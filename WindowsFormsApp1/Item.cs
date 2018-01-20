using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Item
    {
        public string Name;
        public string Description;
        public int Value;

        public Item(string name, int value, string description)
        {
            Name = name;
            Value = value;
            Description = description;
        }
    }
}
