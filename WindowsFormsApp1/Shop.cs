using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class Shop
    {
        public string Name = "";
        public string Description = "";
        public List<Item> Inventory = new List<Item>();

        public void AddItem(string name, int value, string description)
        {
            Inventory.Add(new Item(name, value, description));
        }

        public void ExportAsHTML(string directory, string filename)
        {
            StreamWriter writer = new StreamWriter(directory + filename);
            writer.WriteLine("<html>");
            writer.WriteLine("<body bgcolor='Linen' text='FireBrick'>");
            writer.WriteLine("<h1>" + Name + "</h1>");
            writer.WriteLine("<p>" + Description + "</p>");
            writer.WriteLine("<ul>");
            foreach (Item i in Inventory)
            {
                writer.WriteLine("<li>" + i.Name + ": " + i.Value + "</li>");
            }
            writer.WriteLine("</ul>");
            writer.WriteLine("</body>");
            writer.WriteLine("</html>");
            writer.Close();
        }
    }
}
