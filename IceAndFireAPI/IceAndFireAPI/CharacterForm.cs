using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IceAndFireAPI.Objects;

namespace IceAndFireAPI
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        public async void FindCharacter(string CharacterID)
        {
            Character c = await JsonHelper.GetCharacter(CharacterID);
            List<string> AllegianceList = new List<string>();

            foreach (string element in c.allegiances)
            {
                House h = await JsonHelper.GetHouse(element);
                AllegianceList.Add(h.name);
            }

            listbox_Allegiance.DataSource = AllegianceList;
            label_Name.Text = c.Name;
            label_Gender.Text = c.Gender;
            label_Culture.Text = c.Culture;
            label_Born.Text = c.Born;
            label_Died.Text = c.Died;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int CharacterID;

            try
            {
                CharacterID = int.Parse(txt_CharacterID.Text);
                if (CharacterID > 0 && CharacterID < 2139)
                {
                    FindCharacter(CharacterID.ToString());
                }
                else
                {
                    MessageBox.Show("The Character ID entered is not valid, please try again!");
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("The Character ID entered is not valid, please try again!");
            }
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {
            string InitialCharacter = "588";
            FindCharacter(InitialCharacter);
        }
    }
}
