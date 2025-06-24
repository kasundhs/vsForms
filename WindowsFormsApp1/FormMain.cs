using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        private UserDetails userDetails = new UserDetails(); // Shared model object

        public FormMain()
        {
            InitializeComponent();
            button1.Enabled = false; // Hide until data entered
            button2.Enabled = true;
        }

        private void button_enterDetails_Click(object sender, EventArgs e)
        {
            FormAddressDetails adf = new FormAddressDetails();
            adf.UserData = userDetails; // Pass reference
            adf.ShowDialog(); // Modal

            if (!string.IsNullOrEmpty(userDetails.FName)) // Basic check
            {
                button1.Enabled = true;
                MessageBox.Show("Details submitted successfully.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_enterDetails_Click(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormSummary summaryForm = new FormSummary();
            summaryForm.UserData = this.userDetails; // Pass the data before showing the form
            summaryForm.ShowDialog();
        }
    }
}
