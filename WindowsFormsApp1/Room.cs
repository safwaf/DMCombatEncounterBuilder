using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class Room
    {
        //the relative position of the room. The entrance is 0,0
        public int XPosition;
        public int YPosition;
        //room exits default to null. if exit remains null, this means there is no exit in that direction
        public Room EastExit = null;
        public Room NorthExit = null;
        public Room SouthExit = null;
        public Room WestExit = null;

        public string Name;
        public string Description;

        //the app currently limits the player to one encounter per room
        public Encounter Encounter = null;


        public void ExportAsHTML(string Directory,string filename)
        {
            StreamWriter SW = new StreamWriter(Directory + filename);
            SW.WriteLine("<HTML>");
            SW.WriteLine("<SCRIPT>");
            //comments within the script tags will be a good place to store information for parsing/extraction later
            //there may also be functionality built in here sometimes (Although best practice is to use an external script file and reference it from each page)
            SW.WriteLine("</SCRIPT>");
            SW.WriteLine("<BODY bgcolor=\"Linen\" text =\"FireBrick\">");   //later we can use this to customize colour schemes for each monster. For now, we replicate the MM color scheme
            SW.WriteLine("<h1>" + Name + "</h1><br>");
            SW.WriteLine(Description);
            if (Encounter != null)
            {
                SW.WriteLine("<a href=\"" + Encounter.Name + ".html\">"+Encounter.Name+"</a><br>");
            }
            if (EastExit != null)
            {
                SW.WriteLine("<a href=\"" + EastExit.Name + ".html\">Exit East</a><br>");
            }
            if (NorthExit != null)
            {
                SW.WriteLine("<a href=\"" + NorthExit.Name + ".html\">Exit North</a><br>");
            }
            if (SouthExit != null)
            {
                SW.WriteLine("<a href=\"" + WestExit.Name + ".html\">Exit South</a><br>");
            }
            if (WestExit != null)
            {
                SW.WriteLine("<a href=\"" + SouthExit.Name + ".html\">Exit West</a><br>");
            }

        }

    }
}
