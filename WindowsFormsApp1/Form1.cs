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
        Shop ActiveShop = new Shop();

        public CombatEncounterBuilder()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void SaveCreatureButton_Click(object sender, EventArgs e)
        {
            if (!IsFormComplete())  //if the form is not filled out properly, we will exit. IsFormComplete displays the errors itself
            {
                return;
            }
            BuildActiveCreature();
            ActiveCreature.ExportAsHTML("",ActiveCreature.Name+".html");
        }

        private bool IsFormComplete()
        {
            //this function checks to make sure all necessary form controls have been properly filled
            //in the future, it may also give warnings or recommendations about inadvisable creature choices (e.g. a creature with a speed of 0 cannot move)
            if (NameTextBox.Text == "")
            {
                IncompleteFormLabel.Text = "Please provide a monster name";
                return false;
            }
            if (HitPointsNumeric.Value == 0)
            {
                IncompleteFormLabel.Text = "A creature cannot have less than 1 hit point";
                return false;
            }
            return true;
        }

        private void BuildActiveCreature()
        {
            //This function builds all of the form data into the creature in preparation for saving
            //We use this to avoid constantly updating the object every time the user adjusts a control
            ActiveCreature.Name = NameTextBox.Text;
            ActiveCreature.Size = (enumSize)SizeComboBox.SelectedIndex;
            ActiveCreature.Type = (enumType)TypeComboBox.SelectedIndex;
            ActiveCreature.Alignment = (enumAlignment)AlignmentComboBox.SelectedIndex;
            ActiveCreature.ArmorClass = (int)ArmorClassNumeric.Value;
            ActiveCreature.HitPoints = (int)HitPointsNumeric.Value;
            ActiveCreature.Speed = (int)SpeedNumeric.Value;
            ActiveCreature.ChallengeRating = (int)ChallengeRatingNumeric.Value;
            ActiveCreature.Strength = (int)StrengthNumeric.Value;
            ActiveCreature.Dexterity = (int)DexterityNumeric.Value;
            ActiveCreature.Constitution = (int)ConstitutionNumeric.Value;
            ActiveCreature.Intelligence = (int)IntelligenceNumeric.Value;
            ActiveCreature.Wisdom = (int)WisdomNumeric.Value;
            ActiveCreature.Charisma = (int)CharismaNumeric.Value;
            ActiveCreature.Notes = NotesTextBox.Text;
            //Actions are already set using the "Add Action" button
            ActiveCreature.CalculateXP();   //XP is not currently a separate input
        }

        private void BuildActiveShop()
        {
            ActiveShop.Name = ShopNameBox.Text;
            ActiveShop.Description = ShopDescriptionBox.Text;
        }

        private void ShopAddItemButton_Click(object sender, EventArgs e)
        {
            ActiveShop.AddItem(ShopItemNameBox.Text,
                Int32.Parse(ShopItemValueBox.Text),
                ShopItemDescriptionBox.Text);
            ShopSelectedItemComboBox.Items.Add(ShopItemNameBox.Text);
            ShopItemNameBox.Clear();
            ShopItemValueBox.Clear();
            ShopItemDescriptionBox.Clear();
        }

        private void ShopSelectedItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopSelectedItemValueBox.Text = ActiveShop.Inventory[ShopSelectedItemComboBox.SelectedIndex].Value.ToString();
            ShopSelectedItemDescriptionBox.Text = ActiveShop.Inventory[ShopSelectedItemComboBox.SelectedIndex].Description;
        }

        private void ShopSaveButton_Click(object sender, EventArgs e)
        {
            if (!ShopIsFormComplete())  //if the form is not filled out properly, we will exit. IsFormComplete displays the errors itself
            {
                return;
            }
            BuildActiveShop();
            ActiveShop.ExportAsHTML("", ActiveShop.Name + ".html");
        }

        private bool ShopIsFormComplete()
        {
            //this function checks to make sure all necessary form controls have been properly filled
            //in the future, it may also give warnings or recommendations about inadvisable creature choices (e.g. a creature with a speed of 0 cannot move)
            if (ShopNameBox.Text == "")
            {
                ShopIncompleteFormBox.Text = "Please provide a shop name";
                return false;
            }
            
            return true;
        }
    }
}
