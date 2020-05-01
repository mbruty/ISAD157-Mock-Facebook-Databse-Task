using FacebookUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FacebookUI
{
    public partial class LoginForm : Form
    {
        private ProfileForm profile;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void UserLoginBtn_Click(object sender, EventArgs e)
        {
            int userID;
            if (int.TryParse(user_ID_txtbox.Text, out userID))
            {
                profile = new ProfileForm(userID);
                profile.Show();
                profile.logOut += relogIn;
                this.Hide();
            }
            else
            {
                MessageBox.Show("User ID can only be numeric");
            }
        }

        private void relogIn(object sender, EventArgs e)
        {
            user_ID_txtbox.Text = "";
            this.Show();
            profile.Dispose();
        }
        private void user_ID_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserLoginBtn_Click(null, null);
            }
        }
    }
}
