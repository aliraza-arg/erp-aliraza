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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select grpname from cusgroup;", mc.conn);
            OleDbDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["grpname"]);

            }
            mc.conn.Close();
        
        myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd = new OleDbCommand("select CID from customer;", mc1.conn);
            OleDbDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["cid"]);

            }
            mc1.conn.Close();

            if (Form2.approvalStatus) {
                this.button1.Text = "Update Status";
                this.textBox2.ReadOnly = this.textBox3.ReadOnly = this.textBox4.ReadOnly =
                this.textBox5.ReadOnly = this.textBox6.ReadOnly = this.textBox7.ReadOnly =
                this.textBox8.ReadOnly = this.textBox9.ReadOnly = this.textBox10.ReadOnly = true;
            }
            







        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();
            if (Form2.approvalStatus)
            {
                //UPDATE table_name
//SET column1 = value1, column2 = value2...., columnN = valueN
//WHERE [condition];

                OleDbCommand cmd = new OleDbCommand("update Customer SET Cstatus = '" + this.textBox11.Text + "' where CID='"+ this.comboBox2.Text + "';", mc.conn);
                cmd.ExecuteReader();
                MessageBox.Show("Status successfully updated");
            }
            else
            {

                OleDbCommand cmd = new OleDbCommand("insert into customer(cid,cname,caddress,city,ph1,ph2,contectperson,cpph,cemail,creditlimit,cstatus,cgroup)values(@cid,@cname,@caddress,@city,@ph1,@ph2,@contectperson,@cpph,@cemail,@creditlimit,@cstatus,@cgroup);", mc.conn);
                cmd.Parameters.AddWithValue("@cid", comboBox2.Text);
                cmd.Parameters.AddWithValue("@cname", textBox2.Text);
                cmd.Parameters.AddWithValue("@caddress", textBox3.Text);
                cmd.Parameters.AddWithValue("@city", textBox4.Text);
                cmd.Parameters.AddWithValue("@ph1", textBox5.Text);
                cmd.Parameters.AddWithValue("@ph2", textBox6.Text);
                cmd.Parameters.AddWithValue("@contectperson", textBox7.Text);
                cmd.Parameters.AddWithValue("@cpph", textBox8.Text);
                cmd.Parameters.AddWithValue("@cemail", textBox9.Text);
                cmd.Parameters.AddWithValue("@creditlimit", textBox10.Text);
                cmd.Parameters.AddWithValue("@cstatus", textBox11.Text);
                cmd.Parameters.AddWithValue("@cgroup", comboBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Customer has been added");
            }
            mc.conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Form2.approvalStatus)
            {
                myconnection mc = new myconnection();
                mc.conn.Open();
                OleDbCommand cmd1 = new OleDbCommand("select * from Customer where CID= '" + comboBox2.Text + "';", mc.conn);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                
                while (dr1.Read())
                {
                    this.textBox2.Text = dr1["Cname"].ToString();
                    this.textBox3.Text = dr1["CAddress"].ToString();
                    this.textBox4.Text = dr1["City"].ToString();
                    this.textBox5.Text = dr1["PH1"].ToString();
                    this.textBox6.Text = dr1["PH2"].ToString();
                    this.textBox7.Text = dr1["ContectPerson"].ToString();
                    this.textBox8.Text = dr1["CPPH"].ToString();
                    this.textBox9.Text = dr1["CEmail"].ToString();
                    this.textBox10.Text = dr1["CreditLimit"].ToString();
                    this.textBox11.Text = dr1["CStatus"].ToString();
                    this.comboBox1.Text = dr1["CGroup"].ToString();
                }
                mc.conn.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        }

    }

