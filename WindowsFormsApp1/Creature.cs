using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        string Name;
        enumSize Size;
        enumType Type;
        enumAlignment Alignment;
        int ArmorClass;
        int HitPoints;
        int Speed;
        int ChallengeRating;
        int XP;
        int Strength;
        int Dexterity;
        int Constitution;
        int Intelligence;
        int Wisdom;
        int Charisma;
        public List<Action> ActionList = new List<Action>();

        public void AddAction(string ActionName,string ActionDescription)
        {
            ActionList.Add(new Action(ActionName, ActionDescription));
        }

        public void ExportCreatureAsHTML()
        {

        }
    }
}
