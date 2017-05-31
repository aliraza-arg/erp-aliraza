using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select SOID from SO;", mc.conn);
            OleDbDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["SOID"]);

            }
            mc.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();

            {


                OleDbCommand cmd = new OleDbCommand("update SO SET approve = '" + this.comboBox2.Text + "' where SOID='" + this.comboBox1.Text + "';", mc.conn);
                cmd.ExecuteReader();

            }

            myconnection mc1 = new myconnection();
            mc1.conn.Open();

            {


                OleDbCommand cmd1 = new OleDbCommand("update SO SET status = '" + this.comboBox3.Text + "' where SOID='" + this.comboBox1.Text + "';", mc1.conn);
                cmd1.ExecuteReader();
                MessageBox.Show("Status successfully updated");
            }
        }
    }
}
