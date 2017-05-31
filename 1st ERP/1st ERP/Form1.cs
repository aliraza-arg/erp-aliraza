using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text == "BS3A")
            {
                Form2 f2 = new Form2();
                f2.Show();

            }
            else
            {

                MessageBox.Show("please Enter a Valid user name or Password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.AcceptButton = this.button1;
            this.textBox1.Focus();
            this.textBox1.Text = "test";
            this.textBox2.Text = "BS3A";
        }
    }
}
