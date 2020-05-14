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
    public partial class ProfilePicker : Form
    {
        private List<String[]> profiles;
        public EventHandler profilePicked;
        public ProfilePicker(List<String[]> input)
        {
            InitializeComponent();
            this.profiles = input;
            populateDataGrid();
            formStarted?.Invoke(this, EventArgs.Empty);
        }

        private void populateDataGrid()
        {
            // User ID | First Name | Last Name | Current City |
            DataTable profileTable = new DataTable("Profiles");
            profileTable.Columns.Add("User ID");
            profileTable.Columns.Add("First Name");
            profileTable.Columns.Add("Last Name");
            profileTable.Columns.Add("Current City");

            foreach (String[] profile in profiles)
            {
                profileTable.Rows.Add(profile);
            }
            profilesDGV.DataSource = profileTable;
        }

        private void viewProfileBtn_Click(object sender, EventArgs e)
        {
            profilePicked?.Invoke(this, e);
        }

        public int getID()
        {
            return int.Parse(profilesDGV.Rows[profilesDGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
        }
    }
}
