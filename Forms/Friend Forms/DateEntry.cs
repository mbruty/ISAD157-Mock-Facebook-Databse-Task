using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookUI.Forms.Friend_Forms
{
    public partial class DateEntry : Form
    {
        int userID;
        bool endDatePicked = false;
        public EventHandler submitted;
        public DateEntry(string lblTxt, int userID)
        {
            InitializeComponent();
            nameLbl.Text = lblTxt;
            this.userID = userID;
            txtLengthLbl.Visible = false;
            endDateTime.CustomFormat = " ";
            endDateTime.Format = DateTimePickerFormat.Custom;
        }
        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            if(inputBox.Text.Length > 25)
            {
                txtLengthLbl.Visible = true;
            }
            else
            {
                txtLengthLbl.Visible = false;
            }
        }

        private void endDateTime_ValueChanged(object sender, EventArgs e)
        {
            endDateTime.Format = DateTimePickerFormat.Long;
            endDatePicked = true;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(nameLbl.Text == "Workplace Name")
            {
                Task.Run(async () =>
                {
                    return await DataBase.uploadNewWorkPlace(this.userID, startDateTime.Value, endDatePicked ? endDateTime.Value : (DateTime?)null, Util.UppercaseFirst(inputBox.Text));
                }).ContinueWith((result) =>
                {
                    if (result.Result)
                    {
                        submitted?.Invoke(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert workplace");
                    }
                });
            }
            else if (nameLbl.Text == "University Name")
            {
                Task.Run(async () =>
                {
                    return await DataBase.uploadNewUni(this.userID, startDateTime.Value, endDatePicked ? endDateTime.Value : (DateTime?)null, Util.UppercaseFirst(inputBox.Text));
                }).ContinueWith((result) =>
                {
                    if (result.Result)
                    {
                        submitted?.Invoke(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert workplace");
                    }
                });
            }
            this.Hide();
        }
    }
}
