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
    public partial class FormAddressDetails : Form
    {
        public UserDetails UserData { get; set; }

        public FormAddressDetails()
        {
            InitializeComponent();
        }
        int validate_fields(String value, int category)
        {
            switch(category)
            {
                case 0:
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                        {
                            return 1;
                        }
                        else
                        {
                            MessageBox.Show("First Name/ Last Name/ City Field entry is wrong");
                            return 0;
                        }
                    }
                case 1:
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^[a-zA-Z0-9\s,./\-#]+$"))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                case 2:
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^\d+$"))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }

            }
            return 1;
        }

        private void button_submitDetails_Click(object sender, EventArgs e)
        {
            String firstName, lastName, addressLine1, addressLine2, city, postcode;
            int result;

            firstName = textBox1.Text;
            result = validate_fields(firstName, 0);
            if (result == 1)
                UserData.FName = firstName;

            lastName = textBox2.Text;
            result = validate_fields(lastName, 0);
            if (result == 1)
                UserData.LName = lastName;

            addressLine1 = textBox3.Text;
            result = validate_fields(addressLine1, 1);
            if (result == 1)
                UserData.AddLine1 = addressLine1;

            addressLine2 = textBox4.Text;
            result = validate_fields(addressLine2,1);
            if (result == 1)
                UserData.AddLine2 = addressLine2;

            city = textBox5.Text;
            result = validate_fields(city, 0);
            if (result == 1)
                UserData.City = city;

            postcode = textBox6.Text;
            result = validate_fields(postcode, 2);
            if (result == 1)
                UserData.PostCode = postcode;

            this.Close(); // Return to main
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_submitDetails_Click(sender, e);
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
