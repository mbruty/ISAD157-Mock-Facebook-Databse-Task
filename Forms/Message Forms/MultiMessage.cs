using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookUI.Forms
{
    class MultiMessage : MessageForm
    {
        private string recipientIDs;
        private new int userID;
        private DataTable dataTable;
        public MultiMessage(int userID) : base()
        {
            this.userID = userID;
            base.toTxtBox.ReadOnly = false;
            base.toTxtBox.Text = "";
            base.multiMsgBtn.Text = "Set Users";
            base.toTxtBox.KeyPress += this.toTxtBox_KeyPress;
            base.msgLbl.Text = "Message Recipients: (User ID Only)";
            base.sendBtn.Click += this.sendBtn_Click;

            dataTable = new DataTable("Message Data");
            dataTable.Columns.Add("Message Recipients");
            dataTable.Columns.Add("Message Text");
            base.messageDGV.DataSource = this.dataTable;
        }

        protected override void sendBtn_Click(object sender, EventArgs e)
        {
            string text = msgTxtBox.Text;
            msgTxtBox.Text = "";
            if (msgTxtBox.TextLength > 255)
            {
                MessageBox.Show("Message cannot be longer than 255 characters!");
            }
            else
            {
                Task.Run(async () =>
                {
                    return await DataBase.sendMessage(text, this.userID, this.recipientIDs);
                }).ContinueWith((reult) =>
                {
                    if (reult.Result)
                    {
                        base.messageDGV.Rows.Add(this.recipientIDs, text);
                    }
                    else
                    {
                        MessageBox.Show("Failed to send message");
                    }
                });
            }
        }

        private void toTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only accept numbers and commas
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        protected override void multiMsgBtn_Click(object sender, EventArgs e)
        {
            if(multiMsgBtn.Text == "Reset Users")
            {
                base.toTxtBox.Text = recipientIDs;
                base.multiMsgBtn.Text = "Set Users";
            }
            else
            {
                if (toTxtBox.Text.Contains(","))
                {
                    this.recipientIDs = toTxtBox.Text;
                    base.multiMsgBtn.Text = "Reset Users";
                    base.toTxtBox.Text = "";
                    Task.Run(async () =>
                    {
                        return await DataBase.getProfiles(this.recipientIDs);
                    }).ContinueWith((result) =>
                    {
                        Util.SetControlPropertyThreadSafe(base.toTxtBox, "Text", result.Result);
                    });
                }
                else
                {
                    MessageBox.Show("Please seporate user ID's with a comma");
                }
            }
        }
    }
}
