using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 40; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 0; i <= 40; i++)
            {
                comboBox3.Items.Add(i);
            }
            for (int i = 0; i <= 40; i++)
            {
                comboBox5.Items.Add(i);
            }
            for (int i = 0; i <= 40; i++)
            {
                comboBox7.Items.Add(i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label18.Text = comboBox1.SelectedItem.ToString();
            int a = 40 - Convert.ToInt32(comboBox1.SelectedItem);
            for (int i = 0; i <= a; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label17.Text = comboBox3.SelectedItem.ToString();
            int a = 40 - Convert.ToInt32(comboBox3.SelectedItem);
            for (int i = 0; i <= a; i++)
            {
                comboBox4.Items.Add(i);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            label16.Text = comboBox5.SelectedItem.ToString();
            int a = 40 - Convert.ToInt32(comboBox5.SelectedItem);
            for (int i = 0; i <= a; i++)
            {
                comboBox6.Items.Add(i);
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            label15.Text = comboBox7.SelectedItem.ToString();
            int a = 40 - Convert.ToInt32(comboBox7.SelectedItem);
            for (int i = 0; i <= a; i++)
            {
                comboBox8.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double not = Convert.ToDouble(textBox1.Text);
            if (not < 50)
            {
                textBox1.Text = "50";
            }
            else if (not > 100)
            {
                textBox1.Text = "100";
            }
        }
    }
}
