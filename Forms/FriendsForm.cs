using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookUI
{
    public partial class FriendsForm : Form
    {
        private int userID;
        public EventHandler viewBtnClick;
        public FriendsForm(int userID, bool ownProfile)
        {
            InitializeComponent();
            this.userID = userID;
            populateData();
            if (!ownProfile)
            {
                friendsBtn.Hide();
                msgBtn.Hide();
            }
        }

        public int getSelectedProfile()
        {
            return int.Parse(friendsDGV.Rows[friendsDGV.CurrentCell.RowIndex].Cells[2].Value.ToString());
        }

        private void populateData()
        {
            Task.Run(async () =>
            {
                DataTable result = await DataBase.getUserFriends(this.userID);
                Util.SetControlPropertyThreadSafe(friendsDGV, "DataSource", result);
            });
        }

        private void friendsBtn_Click(object sender, EventArgs e)
        {
            int friendID = int.Parse(friendsDGV.Rows[friendsDGV.CurrentCell.RowIndex].Cells[2].Value.ToString());
            Task.Run(async () =>
            {
                bool result = await DataBase.removeFriend(this.userID, friendID);
                if (result)
                {
                    MessageBox.Show("Removed Friend");
                    populateData();
                }
                else
                {
                    MessageBox.Show("Failed to remove friend");
                }
            });
        }

        private void viewProfileBtn_Click(object sender, EventArgs e)
        {
            viewBtnClick(sender, e);
        }
    }
}
