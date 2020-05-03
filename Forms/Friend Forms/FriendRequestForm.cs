using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookUI
{
    class FriendRequestForm : FriendsForm
    {
        private int userID;
        public FriendRequestForm(int userID) : base()
        {
            base.viewProfileBtn.Text = "Reject Request";
            base.msgBtn.Text = "Accpet Request";
            this.userID = userID;
            populateData();
        }

        protected override void populateData()
        {
            Task.Run(async () =>
            {
                return await DataBase.getFriendRequests(this.userID);
            }).ContinueWith((result) =>
            {
                Util.SetControlPropertyThreadSafe(friendsDGV, "DataSource", result.Result);
            });
        }
        protected override void viewProfileBtn_Click(object sender, EventArgs e)
        {
            int friendID = int.Parse(friendsDGV.Rows[friendsDGV.CurrentCell.RowIndex].Cells[2].Value.ToString());
            Task.Run(async () =>
            {
                return await DataBase.rejectFriend(userID, friendID);
            }).ContinueWith((result) =>
            {
                if (result.Result)
                {
                    populateData();
                }
                else
                {
                    MessageBox.Show("Failed to reject friendrequest");
                }
            });
            }

        //Accepted friend request
        protected override void msgBtn_Click(object sender, EventArgs e)
        {
            int friendID = int.Parse(friendsDGV.Rows[friendsDGV.CurrentCell.RowIndex].Cells[2].Value.ToString());
            Task.Run(async () =>
            {
                return await DataBase.acceptFriend(this.userID, friendID);
            }).ContinueWith((result) =>
            {
                if (result.Result)
                {
                    this.populateData();
                    MessageBox.Show("Added friend!");
                }
                else
                {
                    MessageBox.Show("Failed to add friend");
                }
            });
        }
    }
}
