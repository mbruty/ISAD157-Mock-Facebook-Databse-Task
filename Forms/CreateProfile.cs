using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookUI.Forms
{
    public partial class CreateProfile : Form
    {
        private const int maxInputLength = 25;
        private int userID;
        public EventHandler created;
        private Dictionary<string, string> genderDict, relationshipDict;
        public CreateProfile()
        {
            InitializeComponent();
            fillDictionaries();
            Util.SetControlPropertyThreadSafe(maxInputLbl, "Visible", false);
        }

        private void fillDictionaries()
        {
            //Creating the dictionary to convert back to gender
            genderDict = new Dictionary<string, string>();
            genderDict.Add("0", "Male");
            genderDict.Add("1", "Female");
            genderDict.Add("2", "Unspecified");

            //Creating dictionary to convert back to relationship status
            relationshipDict = new Dictionary<string, string>();
            relationshipDict.Add("0", "Single");
            relationshipDict.Add("1", "Engaged");
            relationshipDict.Add("2", "Married");
            relationshipDict.Add("3", "It's Complicated");
        }

        private void checkTxtBoxSize(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.TextLength > maxInputLength)
            {
                txtBox.BackColor = Color.FromArgb(255, 183, 183);
                Util.SetControlPropertyThreadSafe(maxInputLbl, "Visible", true);
            }
            else
            {
                txtBox.BackColor = SystemColors.ControlLightLight;
                Util.SetControlPropertyThreadSafe(maxInputLbl, "Visible", false);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(nameTxtBox.Text == "" ||genderCombo.Text == "" || homeTxtBox.Text == "" || currCityTxtBox.Text == "" || relationshipCombo.Text == "")
            {
                MessageBox.Show("No fields can be empty");
            }
            else
            {
                string[] names = nameTxtBox.Text.Split(' ');
                if(names.Length < 2)
                {
                    MessageBox.Show("Please provide a first name and last name");
                }
                else
                {
                    string gender = genderDict.FirstOrDefault(x => x.Value == genderCombo.Text).Key;
                    string relationship = relationshipDict.FirstOrDefault(x => x.Value == relationshipCombo.Text).Key;
                    string[] profile = { names[0], names[names.Length - 1], gender, homeTxtBox.Text, currCityTxtBox.Text, relationship };
                    Task.Run(async () =>
                    {
                        return await DataBase.createUserProfile(profile);
                    }).ContinueWith((result) =>
                    {
                        if (result.Result != 0)
                        {
                            this.userID = result.Result;
                            MessageBox.Show("User ID : " + this.userID.ToString());
                            created(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("Failed to create profile, please try again");
                        }
                    });
                }
            }
        }
        public int getUserID()
        {
            return this.userID;
        }
    }
}
