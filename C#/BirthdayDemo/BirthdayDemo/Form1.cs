using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void birthdateMessage_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            // Work out how old the person is 
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimePickerBirthdate.Value;
            int years = (int)ageDays.TotalDays / 365;

            // Get their birthday details to display
            int day = dateTimePickerBirthdate.Value.Day;
            string month = dateTimePickerBirthdate.Value.ToString("MMMM");

            labelMessage.Text = "Hello, " + name + "! You will be " + (years) + " years old on " + day + " " + month + ".";

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
