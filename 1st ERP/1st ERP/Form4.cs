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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select POID from PO;", mc.conn);
            OleDbDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["POID"]);

            }
            mc.conn.Close();

            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd = new OleDbCommand("select grpname from cusgroup;", mc1.conn);
            OleDbDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                comboBox4.Items.Add(dr1["grpname"]);

            }
            mc1.conn.Close();

            myconnection mc2 = new myconnection();
            mc2.conn.Open();
            OleDbCommand cmd2 = new OleDbCommand("select VName from Vendor;", mc2.conn);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox5.Items.Add(dr2["VName"]);

            }
            mc2.conn.Close();

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from Vendor where VName= '" + comboBox5.Text + "';", mc1.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                this.textBox3.Text = dr1["VID"].ToString();
                this.textBox4.Text = dr1["CPName"].ToString();
                this.textBox5.Text = dr1["CPPH"].ToString();
                

            }
            mc1.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into PO(POID,DCDate,DDate,Status,Approve,VDept,VName,VID,VContectPerson,VCPPH,TotalAmount,SNO,GoodRecieved)values(@POID,@DCDate,@DDate,@Status,@Approve,@VDept,@VName,@VID,@VContectPerson,@VCPPH,@TotalAmount,@SNO,@GoodRecieved);", mc.conn);
            cmd.Parameters.AddWithValue("@POID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@DCDate", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker2.Value.Date);
            cmd.Parameters.AddWithValue("@Status", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Approve", comboBox3.Text);
            cmd.Parameters.AddWithValue("@VDept", comboBox4.Text);
            cmd.Parameters.AddWithValue("@VName", comboBox5.Text);
            cmd.Parameters.AddWithValue("@VID", textBox3.Text);
            cmd.Parameters.AddWithValue("@VContectPerson", textBox4.Text);
            cmd.Parameters.AddWithValue("@VCPPH", textBox5.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", textBox6.Text);
            cmd.Parameters.AddWithValue("@SNO", textBox7.Text);
            cmd.Parameters.AddWithValue("@GoodRecieved", comboBox6.Text);
            cmd.ExecuteNonQuery();
            mc.conn.Close();
            MessageBox.Show("New Purchase Order has been Added..!!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
