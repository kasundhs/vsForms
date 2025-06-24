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
    public partial class FormSummary : Form
    {

        public UserDetails UserData { get; set; }

        public FormSummary()    
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.FormSummary_Load);

        }

        private void FormSummary_Load(object sender, EventArgs e)
        {
            //label_name.Text = $"{UserData.FName} {UserData.LName}";
            //label_address.Text = $"{UserData.AddLine1}, {UserData.AddLine2}";
            //label_city.Text = UserData.City;
            //label_postcode.Text = UserData.PostCode;
            if (UserData != null && !string.IsNullOrEmpty(UserData.FName))
            {

                textBox1.Text = $"{UserData.FName} {UserData.LName}";
                textBox2.Text = $"{UserData.AddLine1}, {UserData.AddLine2}";
                textBox3.Text = UserData.City;
                textBox4.Text = UserData.PostCode;
            }
            else
            {
                MessageBox.Show("UserData is null or empty!", "Debug");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
