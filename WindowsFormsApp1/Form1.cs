using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CombatEncounterBuilder : Form
    {
        List<Creature> CreatureList = new List<Creature>();
        Creature ActiveCreature = new Creature();
        public CombatEncounterBuilder()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ActionAddButton_Click(object sender, EventArgs e)
        {
            ActiveCreature.AddAction(ActionTextBox.Text, ActionDescriptionTextBox.Text);
            SelectedActionComboBox.Items.Add(ActionTextBox.Text);
            ActionTextBox.Clear();
            ActionDescriptionTextBox.Clear();
        }

        private void SelectedActionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedActionDescriptionTextBox.Text = ActiveCreature.ActionList[SelectedActionComboBox.SelectedIndex].Description;
        }
    }
}
