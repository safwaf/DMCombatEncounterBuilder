using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class DungeonDesignControl : UserControl
    {
        //This control designs and displays the geometry of the dungeon
        //clicking on an inactive room will make it the active room
        
            /*
             * Dungeon Building:
             * The first room that the player makes is always the entrance and has the point 0,0
             * 
             */

        List<Point> RoomPoints = new List<Point>();
        Room SelectedRoom;

        public DungeonDesignControl()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Point MousePosition = PointToClient(Cursor.Position);

        }

        private int HighestX()
        {
            int returnValue = 0;    //since every dungeon has an entrance at 0,0, we know the highest x is at least 0
            foreach(Point p in RoomPoints)
            {
                if (p.X > returnValue) returnValue = p.X; 
            }
            return returnValue;
        }
        private int HighestY()
        {
            int returnValue = 0;    
            foreach (Point p in RoomPoints)
            {
                if (p.Y > returnValue) returnValue = p.Y;
            }
            return returnValue;
        }
        private int LowestX()
        {
            int returnValue = 0;    
            foreach (Point p in RoomPoints)
            {
                if (p.X < returnValue) returnValue = p.X;
            }
            return returnValue;
        }
        private int LowestY()
        {
            int returnValue = 0;    
            foreach (Point p in RoomPoints)
            {
                if (p.Y < returnValue) returnValue = p.Y;
            }
            return returnValue;
        }
    }
}
