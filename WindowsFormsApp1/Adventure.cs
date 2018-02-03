using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Adventure
    {
        //this class holds all of the information for a full adventure/dungeon
        //It is responsible for import-export methods relating to putting the adventure on a phone
        //It is the outer container for all relevant data. Only one instance of Adventure should exist at any given time

        //the adventure holds all of the loaded objects
        public List<Room> RoomList = new List<Room>();
        public List<Encounter> EncounterList = new List<Encounter>();
        public List<Creature> CreatureList = new List<Creature>();
        public List<NPC> NPCList = new List<NPC>();
        public List<Shop> ShopList = new List<Shop>();
        public List<Item> ItemList = new List<Item>();
        public List<Trap> TrapList = new List<Trap>();
    }
}
