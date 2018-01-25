using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace WindowsFormsApp1
{
    struct Action
    {
        public string Name;
        public string Description;
        public Action(string n,string d)
        {
            Name = n;
            Description = d;
        }
    }

    enum enumSize
    {
        Tiny,
        Small,
        Medium,
        Large,
        Huge,
        Gargantuan
    }

    enum enumType
    {
        Aberration,
        Beast,
        Celestial,
        Construct,
        Dragon,
        Elemental,
        Fey,
        Fiend,
        Giant,
        Humanoid,
        Monstrosity,
        Ooze,
        Plant,
        Undead,
        Other
    }

    enum enumAlignment
    {
        Unaligned,
        LawfulGood,
        NeutralGood,
        ChaoticGood,
        LawfulNeutral,
        TrueNeutral,
        ChaoticNeutral,
        LawfulEvil,
        NeutralEvil,
        ChaoticEvil
    }

    class Creature
    {
        public string Name;
        public enumSize Size;
        public enumType Type;
        public enumAlignment Alignment;
        public int ArmorClass;
        public int HitPoints;
        public int Speed;
        public int ChallengeRating;
        public int XP;
        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;
        public List<Action> ActionList = new List<Action>();
        public string Notes;

        public void AddAction(string ActionName,string ActionDescription)
        {
            ActionList.Add(new Action(ActionName, ActionDescription));
        }

        public void CalculateXP()
        {
            //this function gets an XP value from a Challenge Rating
            //not completed
            XP = ChallengeRating * 100;
        }
        public Creature()
        {

        }


        public Creature(string Directory, string filename)
        {
            //this constructor creates the object by parsing it from an XML file
            //bulky. Consider reconfiguring all save-load classes to store variables in an array/list, then we could make use of a generic parser
            XmlDocument LoadFile = new XmlDocument();
            LoadFile.Load(Directory + filename);
            Name = LoadFile.DocumentElement.SelectSingleNode("Name").Value;
            Size = (enumSize)int.Parse(LoadFile.DocumentElement.SelectSingleNode("Size").Value);
            Type = (enumType)int.Parse(LoadFile.DocumentElement.SelectSingleNode("Type").Value);
            Alignment = (enumAlignment)int.Parse(LoadFile.DocumentElement.SelectSingleNode("Alignment").Value);
            ArmorClass = int.Parse(LoadFile.DocumentElement.SelectSingleNode("ArmorClass").Value);
            HitPoints = int.Parse(LoadFile.DocumentElement.SelectSingleNode("HitPoints").Value);
            Speed = int.Parse(LoadFile.DocumentElement.SelectSingleNode("Speed").Value);
            ChallengeRating = int.Parse(LoadFile.DocumentElement.SelectSingleNode("ChallengeRating").Value);
            XP = int.Parse(LoadFile.DocumentElement.SelectSingleNode("XP").Value);
            Strength = int.Parse(LoadFile.DocumentElement.SelectSingleNode("Strength").Value);
            Dexterity = int.Parse(LoadFile.DocumentElement.SelectSingleNode("Desterity").Value);
            Constitution = int.Parse(LoadFile.DocumentElement.SelectSingleNode("Constitution").Value);
            Intelligence = int.Parse(LoadFile.DocumentElement.SelectSingleNode("Intelligence").Value);
            Wisdom = int.Parse(LoadFile.DocumentElement.SelectSingleNode("Wisdom").Value);
            Charisma = int.Parse(LoadFile.DocumentElement.SelectSingleNode("Charisma").Value);

            //proposed model for loading lists, provided parellel saving method implemented
            int ActionCount = int.Parse(LoadFile.DocumentElement.SelectSingleNode("ActionCount").Value);
            for (int i=1;i<=ActionCount;i++)
            {
                Action newAction = new Action();
                newAction.Name = LoadFile.DocumentElement.SelectSingleNode("Action" + i + "Name").Value;
                newAction.Description = LoadFile.DocumentElement.SelectSingleNode("Action" + i + "Description").Value;
            }
        }

        public void ExportAsXML(string Directory)
        {
            //export method need not perfectly reflect import method, but this is a best practice, and it needs to use the same variable names


        }

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
            SW.WriteLine(Size.ToString() + " " + Type.ToString() + ", " + Alignment.ToString() + "<br>");
            SW.WriteLine("<hr>");
            SW.WriteLine("<h2>Stats</h2><br>");
            SW.WriteLine("<table>");
            SW.WriteLine("<tr><th>Armour Class</th><th>" + ArmorClass + "</th></tr>");
            SW.WriteLine("<tr><th>Hit Points</th><th>" + HitPoints + "</th></tr>");
            SW.WriteLine("<tr><th>Speed</th><th>" + Speed + "</th></tr>");
            SW.WriteLine("<tr><th>Challenge Rating</th><th>" + ChallengeRating + "(" + XP + "XP)" + "</th></tr>");
            SW.WriteLine("<tr>");
            SW.WriteLine("<th>" + "STR : " + Strength + "</th>");
            SW.WriteLine("<th>" + "DEX : " + Dexterity + "</th>");
            SW.WriteLine("<th>" + "CON : " + Constitution + "</th>");
            SW.WriteLine("<th>" + "INT : " + Intelligence + "</th>");
            SW.WriteLine("<th>" + "WIS : " + Wisdom + "</th>");
            SW.WriteLine("<th>" + "CHA : " + Charisma + "</th>");
            SW.WriteLine("</tr></table><br>");
            SW.WriteLine("<hr>");
            SW.WriteLine("<h2>Actions</h2><br>");
            if (ActionList.Count == 0)
            {
                SW.WriteLine("This creature has no actions");
            }
            else
            {
                foreach (Action A in ActionList)
                {
                    SW.WriteLine("<b>"+A.Name+"</b><br>");
                    SW.WriteLine(A.Description + "<br>");
                }
            }
            SW.WriteLine("<hr>");
            SW.WriteLine("<h2>Notes</h2><br>");
            SW.WriteLine(Notes);
            SW.WriteLine("</body>");
            SW.WriteLine("</html>");
            SW.Close();
        }
    }
}
