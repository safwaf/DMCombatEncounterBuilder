using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    struct CreatureInstance
    {
        public string Name;
        public Creature Base;
        public CreatureInstance(string Namep, Creature Basep)
        {
            Name = Namep;
            Base = Basep;
        }
    }

    class Encounter
    {
        public string Name;
        public string Description;
        public string Loot;
        public List<CreatureInstance> CreatureList = new List<CreatureInstance>();


        public void ExportAsHTML(string Directory, string filename)
        {
            StreamWriter SW = new StreamWriter(Directory + filename);
            SW.WriteLine("<HTML>");
            SW.WriteLine("<SCRIPT>");
            //comments within the script tags will be a good place to store information for parsing/extraction later
            //there may also be functionality built in here sometimes (Although best practice is to use an external script file and reference it from each page)
            SW.WriteLine("var numberOfCreatures = " + CreatureList.Count() + ";");
            SW.WriteLine("function ChangeTab() {");
            SW.WriteLine("var c = document.detElementById(\"Creature\").value;");
            SW.WriteLine("for(var i=1;i<numberOfCreatures;i++) {");
            SW.WriteLine("if (i==c) {");
            SW.WriteLine("document.getElementById(\"Div\"+i).style.display=\"block\";");
            SW.WriteLine("} else {");
            SW.WriteLine("document.getElementById(\"Div\"+i).style.display=\"none\";");
            SW.WriteLine("}}}");
            SW.WriteLine("</SCRIPT>");
            SW.WriteLine("<BODY bgcolor=\"Linen\" text =\"FireBrick\">");
            SW.WriteLine("<h1>" + Name + "</h1>");
            SW.WriteLine(Description);
            SW.WriteLine("<HR>");
            SW.WriteLine("Creature:");
            SW.WriteLine("<select id=\"Creature\" onchange=\"ChangeTab()\">");
            for (int i = 1; i <= CreatureList.Count(); i++)
            {
                SW.WriteLine("<option value=\"" + i + "\">" + CreatureList[i - 1].Name + "</option>");
            }
            SW.WriteLine("</select>");

            for (int i = 1; i <= CreatureList.Count(); i++)
            {
                SW.WriteLine("<div id=\"Div" + i + "\" style=\"display:none\">");
                SW.WriteLine("<h3>" + CreatureList[i - 1].Name + "</h3>");
                SW.WriteLine("<iframe src=\"" + CreatureList[i - 1].Base.Name + ".html\">Get a better browser loser</iframe><br>");
                SW.WriteLine("Current HP: <input type=\"number\" value=\"" + CreatureList[i - 1].Base.HitPoints + "\" min=\"0\"> / " + CreatureList[i - 1].Base.HitPoints + "<br>");
                SW.WriteLine("</div>");
            }
            SW.WriteLine("<HR>");
            SW.WriteLine("<h2>Loot:</h2>");
            SW.WriteLine(Loot);
            SW.WriteLine("</body>");
            SW.WriteLine("</html>");
        }
    }
}
