using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    struct CreatureInstance
    {
        public string Name;
        public string Notes;
        public Creature Base;
        public CreatureInstance(string Namep,string Notesp, Creature Basep)
        {
            Name = Namep;
            Notes = Notesp;
            Base = Basep;
        }
    }

    class Encounter
    {
        public string Name;
        public string Description;
        public List<CreatureInstance> CreatureList = new List<CreatureInstance>();


        public void ExportAsHTML(string Directory, string filename)
        {

        }
    }
}
