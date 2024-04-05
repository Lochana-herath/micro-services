using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clean the text boxs
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if name is “Admin” & Password is “Skills@123” then diract to my from2
            if (textBox1.Text == "Admin" && textBox2.Text == "Skills@123")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials,please check Username and Password and try again");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //text is a password
            textBox2.PasswordChar = '*';
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }
    }
}
