using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            XP = ChallengeRating * 100;
        }

        public void ExportCreatureAsHTML(string Directory,string filename)
        {
            StreamWriter PCSW = new StreamWriter(Directory + filename);
            PCSW.WriteLine("<HTML>");
            PCSW.WriteLine("<SCRIPT>");
            //comments within the script tags will be a good place to store information for parsing/extraction later
            //there may also be functionality built in here sometimes (Although best practice is to use an external script file and reference it from each page)
            PCSW.WriteLine("</SCRIPT>");
            PCSW.WriteLine("<BODY bgcolor=\"Linen\" text =\"FireBrick\">");   //later we can use this to customize colour schemes for each monster. For now, we replicate the MM color scheme
            PCSW.WriteLine("<h1>" + Name + "</h1><br>");
            PCSW.WriteLine(Size.ToString() + " " + Type.ToString() + ", " + Alignment.ToString() + "<br>");
            PCSW.WriteLine("<hr>");
            PCSW.WriteLine("<h2>Stats</h2><br>");
            PCSW.WriteLine("<table>");
            PCSW.WriteLine("<tr><th>Armour Class</th><th>" + ArmorClass + "</th></tr>");
            PCSW.WriteLine("<tr><th>Hit Points</th><th>" + HitPoints + "</th></tr>");
            PCSW.WriteLine("<tr><th>Speed</th><th>" + Speed + "</th></tr>");
            PCSW.WriteLine("<tr><th>Challenge Rating</th><th>" + ChallengeRating + "(" + XP + "XP)" + "</th></tr>");
            PCSW.WriteLine("<tr>");
            PCSW.WriteLine("<th>" + "STR : " + Strength + "</th>");
            PCSW.WriteLine("<th>" + "DEX : " + Dexterity + "</th>");
            PCSW.WriteLine("<th>" + "CON : " + Constitution + "</th>");
            PCSW.WriteLine("<th>" + "INT : " + Intelligence + "</th>");
            PCSW.WriteLine("<th>" + "WIS : " + Wisdom + "</th>");
            PCSW.WriteLine("<th>" + "CHA : " + Charisma + "</th>");
            PCSW.WriteLine("</tr></table><br>");
            PCSW.WriteLine("<hr>");
            PCSW.WriteLine("<h2>Actions</h2><br>");
            if (ActionList.Count == 0)
            {
                PCSW.WriteLine("This creature has no actions");
            }
            else
            {
                foreach (Action A in ActionList)
                {
                    PCSW.WriteLine("<b>"+A.Name+"</b><br>");
                    PCSW.WriteLine(A.Description + "<br>");
                }
            }
            PCSW.WriteLine("<hr>");
            PCSW.WriteLine("<h2>Notes</h2><br>");
            PCSW.WriteLine(Notes);
            PCSW.WriteLine("</body>");
            PCSW.WriteLine("</html>");
            PCSW.Close();
        }
    }
}
