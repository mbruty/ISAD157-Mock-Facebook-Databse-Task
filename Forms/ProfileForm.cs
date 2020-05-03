using FacebookUI.Forms.Message_Forms;
using FacebookUI.Properties;
using MySqlX.XDevAPI.Common;
using Renci.SshNet.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookUI
{
    public partial class ProfileForm : Form
    {
        private int userID, viewingID;
        private Dictionary<String, String> gender, relationship;
        public EventHandler logOut;
        private FriendsForm friends;
        private ProfilePicker p;

        private bool viewingOwnProfile = true;
        //Logged in as admin
        public ProfileForm()
        {
            InitializeComponent();
        }
        //Logged in as user
        public ProfileForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.Text = "Logged in as user: " + userID.ToString();

            genderLbl.Hide();
            relationshipLbl.Hide();

        }

        private void fillDictionaries()
        {
            //Creating the dictionary to convert back to gender
            gender = new Dictionary<string, string>();
            gender.Add("0", "Male");
            gender.Add("1", "Female");
            gender.Add("2", "Unspecified");

            //Creating dictionary to convert back to relationship status
            relationship = new Dictionary<string, string>();
            relationship.Add("0", "Single");
            relationship.Add("1", "Engaged");
            relationship.Add("2", "Married");
            relationship.Add("3", "It's Complicated");
        }

        private void setNotOwnProfile()
        {
            viewingOwnProfile = false;
            Util.SetControlPropertyThreadSafe(firstNameTxtBox, "ReadOnly", true);
            Util.SetControlPropertyThreadSafe(lastNameTxtBox, "ReadOnly", true);
            Util.SetControlPropertyThreadSafe(genderTxtBox, "ReadOnly", true);
            Util.SetControlPropertyThreadSafe(homeTownTxtBox, "ReadOnly", true);
            Util.SetControlPropertyThreadSafe(currentCityTxtBox, "ReadOnly", true);
            Util.SetControlPropertyThreadSafe(relationshipTxtBox, "ReadOnly", true);

            Util.SetControlPropertyThreadSafe(relationshipTxtBox, "BackColor", SystemColors.Control);
            Util.SetControlPropertyThreadSafe(genderTxtBox, "BackColor", SystemColors.Control);

            Util.SetControlPropertyThreadSafe(saveChangesBtn, "Visible", false);
            Util.SetControlPropertyThreadSafe(addFriendBtn, "Visible", false);
            Util.SetControlPropertyThreadSafe(removeFriendBtn, "Visible", false);
            Util.SetControlPropertyThreadSafe(messageBtn, "Visible", false);

            Task.Run(async () =>
            {
                return await DataBase.areFriends(this.viewingID, this.userID);
            }).ContinueWith((areFriends) =>
            {
                if (areFriends.Result)
                {
                    Util.SetControlPropertyThreadSafe(removeFriendBtn, "Visible", true);
                    Util.SetControlPropertyThreadSafe(messageBtn, "Visible", true);
                }
                else
                {
                    Util.SetControlPropertyThreadSafe(addFriendBtn, "Visible", true);
                }
            }).ConfigureAwait(true);
        }

        private void setOwnProfile()
        {
            viewingOwnProfile = true;
            this.viewingID = this.userID;
            Util.SetControlPropertyThreadSafe(firstNameTxtBox, "ReadOnly", false);
            Util.SetControlPropertyThreadSafe(lastNameTxtBox, "ReadOnly", false);
            Util.SetControlPropertyThreadSafe(genderTxtBox, "ReadOnly", false);
            Util.SetControlPropertyThreadSafe(homeTownTxtBox, "ReadOnly", false);
            Util.SetControlPropertyThreadSafe(currentCityTxtBox, "ReadOnly", false);
            Util.SetControlPropertyThreadSafe(relationshipTxtBox, "ReadOnly", false);

            Util.SetControlPropertyThreadSafe(relationshipTxtBox, "BackColor", SystemColors.ControlLightLight);
            Util.SetControlPropertyThreadSafe(genderTxtBox, "BackColor", SystemColors.ControlLightLight);

            removeFriendBtn.Hide();
            addFriendBtn.Hide();
            messageBtn.Hide();
            saveChangesBtn.Show();
        }
        private void fillData(int userID)
        {
            if (userID != this.userID)
            {
                this.viewingID = userID;
                setNotOwnProfile();
            }
            else
            {
                setOwnProfile();
            }
            Task.Run(async () =>
            {
                fillProfileData(await DataBase.getUserProfile(userID));
            }).ConfigureAwait(true);

            Task.Run(async () => 
            {
                DataTable result = await DataBase.getWorkplaces(userID);
                try
                {
                    Util.SetControlPropertyThreadSafe(workplaceDGV, "DataSource", result);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }).ConfigureAwait(true);

            Task.Run(async () =>
            {
                DataTable result = await DataBase.getUniversities(userID);
                try
                {
                    Util.SetControlPropertyThreadSafe(uniDGV, "DataSource", result);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }).ConfigureAwait(true);

            Task.Run(async () =>
            {
                String result = await DataBase.getNumFriends(userID);
                Util.SetControlPropertyThreadSafe(numFriendsTxtBox, "Text", result);
            });

            Task.Run(async () =>
            {
                return await DataBase.countUnRead(this.userID);
            }).ContinueWith((result) =>
            {
                Util.SetControlPropertyThreadSafe(unReadMsgsTxt, "Text", result.Result.ToString());
            });

            Task.Run(async () =>
            {
                return await DataBase.countFriendRequests(this.userID);
            }).ContinueWith((result) =>
            {
                Util.SetControlPropertyThreadSafe(friendRequestsTxt, "Text", result.Result.ToString());
            });
        }

        private void fillProfileData(List<String> result)
        {
            Util.SetControlPropertyThreadSafe(firstNameTxtBox, "Text", result.ElementAt(1));
            Util.SetControlPropertyThreadSafe(lastNameTxtBox, "Text", result.ElementAt(2));
            string genderValue = "Error";
            gender.TryGetValue(result.ElementAt(3), out genderValue);
            Util.SetControlPropertyThreadSafe(genderTxtBox, "Text", genderValue);
            Util.SetControlPropertyThreadSafe(homeTownTxtBox, "Text", result.ElementAt(4));
            Util.SetControlPropertyThreadSafe(currentCityTxtBox, "Text", result.ElementAt(5));
            string relationshipValue = "Error";
            relationship.TryGetValue(result.ElementAt(6), out relationshipValue);
            Util.SetControlPropertyThreadSafe(relationshipTxtBox, "Text", relationshipValue);

        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logOut(this, EventArgs.Empty);
        }

        private void workplaceDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            workplaceDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            workplaceDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            workplaceDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void uniDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            uniDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            uniDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            uniDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            string genderValue = gender.FirstOrDefault(x => x.Value == genderTxtBox.Text).Key;


            string relationshipValue = relationship.FirstOrDefault(x => x.Value == relationshipTxtBox.Text).Key;
            String[] profile =
                {
                firstNameTxtBox.Text,
                lastNameTxtBox.Text,
                genderValue,
                homeTownTxtBox.Text,
                currentCityTxtBox.Text,
                relationshipValue
                };
            Task.Run(async () =>
            {
                if(await DataBase.updateUserInfo(profile, this.userID))
                {
                    MessageBox.Show("Successfully updated details");
                    fillData(this.userID);
                }
                else
                    MessageBox.Show("Failed to update details");
            });
        }

        private void genderTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (genderTxtBox.Text != "Male" && genderTxtBox.Text != "Female" && genderTxtBox.Text != "Unspecified")
            {
                genderTxtBox.BackColor = Color.FromArgb(255, 183, 183);
                genderLbl.Show();
            }
            else
            {
                if (viewingOwnProfile)
                {
                    genderTxtBox.BackColor = SystemColors.ControlLightLight;
                    genderLbl.Hide();
                }
                else
                {
                    genderTxtBox.BackColor = SystemColors.Control;
                    genderLbl.Hide();
                }
            }
        }

        private void relationshipTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (relationshipTxtBox.Text != "Single" && relationshipTxtBox.Text != "Engaged" && relationshipTxtBox.Text != "Married" && relationshipTxtBox.Text != "It's Complicated")
            {
                relationshipTxtBox.BackColor = Color.FromArgb(255, 183, 183);
                relationshipLbl.Show();
            }
            else
            {
                if (viewingOwnProfile)
                {
                    relationshipTxtBox.BackColor = SystemColors.ControlLightLight;
                    relationshipLbl.Hide();
                }
                else
                {
                    relationshipTxtBox.BackColor = SystemColors.Control;
                    relationshipLbl.Hide();
                }
            }
        }

        private void friendsBtn_Click(object sender, EventArgs e)
        {
            friends = new FriendsForm(this.viewingID, this.userID == this.viewingID);
            friends.Show();
            friends.viewBtnClick += friendsViewBtn_Click;
        }

        private void friendsViewBtn_Click(object sender, EventArgs e)
        {
            fillData(friends.getSelectedProfile());
            friends.Dispose();
        }

        private async void search()
        {
            int searchID = 0;
            string searchText = searchTxtBox.Text;
            searchTxtBox.Text = "";

            //Check if the user is searching for an ID
            if (int.TryParse(searchText, out searchID))
            {
                this.fillData(searchID);
            }
            else
            {
                String[] searchTerm = searchText.Split(' ');
                List<String[]> result = await DataBase.findUserIDByName(searchTerm);
                if (result.Count == 0)
                {
                    MessageBox.Show("No users were found with that name");
                }
                else if (result.Count == 1)
                {
                    this.fillData(int.Parse(result.ElementAt(0)[0]));
                }
                else
                {
                    p = new ProfilePicker(result);
                    p.Show();
                    p.profilePicked += profilePicked;
                }
            }
        }
        private void profilePicked(object sender, EventArgs e)
        {
            fillData(p.getID());
            p.Dispose();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            search();
        }

        private void removeFriendBtn_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                return await DataBase.removeFriend(this.userID, this.viewingID);
            }).ContinueWith((result) =>
            {
                if (result.Result)
                {
                    MessageBox.Show("Removed Friend");
                }
                else
                {
                    MessageBox.Show("Failed to remove friend");
                }
                this.fillData(this.viewingID);
            });
        }

        private void addFriendBtn_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                return await DataBase.addFriend(this.userID, this.viewingID);
            }).ContinueWith((result) =>
            {
                if (result.Result)
                {
                    fillData(this.viewingID);
                    MessageBox.Show("Friend Added!");
                }
                else
                    MessageBox.Show("Failed to add friend");
            });
        }

        private void messageBtn_Click(object sender, EventArgs e)
        {
            MessageForm mf = new MessageForm(this.userID, this.viewingID, (this.firstNameTxtBox.Text + " " + this.lastNameTxtBox.Text));
            mf.Show();
        }

        private void viewMessagesBtn_Click(object sender, EventArgs e)
        {
            UnreadMessages um = new UnreadMessages(this.userID);
            um.Show();
        }

        private void viewFrndRqBtn_Click(object sender, EventArgs e)
        {
            FriendRequestForm fr = new FriendRequestForm(this.userID);
            fr.Show();
        }

        private void searchTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return) { search(); };
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            //Get the profile data
            Task.Run(async () =>
            {
                bool connected = await DataBase.testConnection();
                if (connected)
                {
                    dbConnectedPic.Image = Resources.baseline_check_circle_black_18dp;
                }
                else
                {
                    dbConnectedPic.Image = Resources.baseline_error_black_18dp;
                }
            });
            fillDictionaries();
            fillData(this.userID);
        }
    }
}
