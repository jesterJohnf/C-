using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQuizWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonQ1A1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonQ1A1.Checked)
            {
                labelFeedbackQ1.ForeColor = Color.Red;
                labelFeedbackQ1.Text = "\u00fb"; // Unicode for cross
            }
            else
            {
                labelFeedbackQ1.Text = "";
            }
        }

        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A2.Checked)
            {
                labelFeedbackQ1.ForeColor = Color.Green;
                labelFeedbackQ1.Text = "\u00fc"; // Unicode for tick
            }
            else
            {
                labelFeedbackQ1.Text = "";
            }
        }

        private void radioButtonQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked)
            {
                labelFeedbackQ3.ForeColor = Color.Red;
                labelFeedbackQ3.Text = "\u00fb"; // Unicode for cross
            }
            else
            {
                labelFeedbackQ3.Text = "";
            }
        }

        private void radioButtonQ2A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A1.Checked)
            {
                labelFeedbackQ2.ForeColor = Color.Red;
                labelFeedbackQ2.Text = "\u00fb"; // Unicode for cross
            }
            else
            {
                labelFeedbackQ2.Text = "";
            }
        }

        private void radioButtonQ2A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A2.Checked)
            {
                labelFeedbackQ2.ForeColor = Color.Red;
                labelFeedbackQ2.Text = "\u00fb"; // Unicode for cross
            }
            else
            {
                labelFeedbackQ2.Text = "";
            }
        }

        private void radioButtonQ2A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A3.Checked)
            {
                labelFeedbackQ2.ForeColor = Color.Green;
                labelFeedbackQ2.Text = "\u00fc"; // Unicode for tick
            }
            else
            {
                labelFeedbackQ2.Text = "";
            }
        }

        private void radioButtonQ3A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A1.Checked)
            {
                labelFeedbackQ3.ForeColor = Color.Red;
                labelFeedbackQ3.Text = "\u00fb"; // Unicode for cross
            }
            else
            {
                labelFeedbackQ3.Text = "";
            }
        }

        private void radioButtonQ3A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A2.Checked)
            {
                labelFeedbackQ3.ForeColor = Color.Red;
                labelFeedbackQ3.Text = "\u00fb"; // Unicode for cross
            }
            else
            {
                labelFeedbackQ3.Text = "";
            }
        }

        private void radioButtonQ3A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A3.Checked)
            {
                labelFeedbackQ3.ForeColor = Color.Green;
                labelFeedbackQ3.Text = "\u00fc"; // Unicode for tick
            }
            else
            {
                labelFeedbackQ3.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
