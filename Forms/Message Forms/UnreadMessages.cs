using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookUI.Forms.Message_Forms
{
    class UnreadMessages : MessageForm
    {
        private new int userID;
        public UnreadMessages(int userID) : base()
        {
            this.userID = userID;
            base.toTxtBox.Visible = false;
            base.msgLbl.Text = "Unread Messages";
            base.msgTxtBox.Visible = false;
            base.charLbl.Visible = false;
            base.sendBtn.Text = "View Conversation";
            base.multiMsgBtn.Visible = false;
        }
        private void loadData()
        {
            Task.Run(async () =>
            {
                return await DataBase.getUnreadMessages(this.userID);
            }).ContinueWith((result) =>
            {
                Util.SetControlPropertyThreadSafe(base.messageDGV, "DataSource", result.Result);
            });
        }
        //Have to do this to over ride the base trying to load data
        protected override void MessageForm_Load(object sender, EventArgs e)
        {
            this.loadData();
        }
        protected override void sendBtn_Click(object sender, EventArgs e)
        {
            string viewName = base.messageDGV.Rows[base.messageDGV.CurrentCell.RowIndex].Cells[0].Value.ToString();
            int viewID = int.Parse(base.messageDGV.Rows[base.messageDGV.CurrentCell.RowIndex].Cells[2].Value.ToString());
            MessageForm mf = new MessageForm(this.userID, viewID, viewName);
            mf.Show();
            this.Hide();


        }
    }
}
