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
        public string Name;
        public string Description;
        public List<Item> Inventory = new List<Item>();

        public void ExportAsHTML(string directory, string filename)
        {
            StreamWriter writer = new StreamWriter(directory + filename);
            writer.WriteLine("<html>");
            writer.WriteLine("<body bgcolor='Linen' text='FireBrick'>");
            writer.WriteLine("<h1>" + Name + "</h1>");

            writer.WriteLine("</body>");
            writer.WriteLine("</html>");
        }
    }
}
