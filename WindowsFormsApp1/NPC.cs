using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    struct DialogueOption
    {
        string prompt;
        string response;

        public DialogueOption(string p, string r)
        {
            prompt = p;
            response = r;
        }
    }

    class NPC
    {
        public Creature Creature;
        public List<DialogueOption> DialogOptions = new List<DialogueOption>();
    }
}
