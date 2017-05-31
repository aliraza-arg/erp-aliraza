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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select DCID from deliverychalan where Status='Open';", mc.conn);
            OleDbDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["DCID"]);

            }
            mc.conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * deliverychalan where DCID= '" + comboBox1.Text + "';", mc1.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                this.textBox1.Text = dr1["tamount"].ToString();
                this.textBox2.Text = dr1["ddate"].ToString();
                this.textBox3.Text = dr1["dcdate"].ToString();
                this.textBox5.Text = dr1["cname"].ToString();
            }
            mc1.conn.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "01")
            {

                textBox6.Text = "Shoaib".ToString();

            }

            if (textBox4.Text == "02")
            {

                textBox6.Text = "asif".ToString();

            }

            if (textBox4.Text == "03")
            {

                textBox6.Text = "sana".ToString();

            }

            if (textBox4.Text == "04")
            {

                textBox6.Text = "adil".ToString();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "STU Pharma")
            {

                textBox4.Text = "01".ToString();

            }

            if (textBox5.Text == "electro nazi")
            {

                textBox4.Text = "02".ToString();

            }

            if (textBox5.Text == "A&B Org.")
            {

                textBox4.Text = "03".ToString();

            }

            if (textBox5.Text == "SHAMS OIL")
            {

                textBox4.Text = "04".ToString();

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "Shoaib")
            {

                textBox7.Text = "21324125".ToString();

            }

            if (textBox6.Text == "asif")
            {

                textBox7.Text = "2121321321".ToString();

            }

            if (textBox6.Text == "sana")
            {

                textBox7.Text = "535353532".ToString();

            }

            if (textBox6.Text == "adil")
            {

                textBox7.Text = "3324242".ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();

            OleDbCommand cmd = new OleDbCommand("insert into sellinvoice(DCID,Amount,DDate,DCDate,CID,CName,ContectPerson,CPPH)values(@DCID,@Amount,@DDate,@DCDate,@CID,@CName,@ContectPerson,@CPPH);", mc.conn);
            cmd.Parameters.AddWithValue("@DCID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Amount", textBox1.Text);
            cmd.Parameters.AddWithValue("@DDate", textBox2.Text);
            cmd.Parameters.AddWithValue("@DCDate", textBox3.Text);
            cmd.Parameters.AddWithValue("@CID", textBox4.Text);
            cmd.Parameters.AddWithValue("@CName", textBox5.Text);
            cmd.Parameters.AddWithValue("@ContectPerson", textBox6.Text);
            cmd.Parameters.AddWithValue("@CPPH", textBox7.Text);


            cmd.ExecuteNonQuery();
            mc.conn.Close();


            myconnection mc2 = new myconnection();
            mc2.conn.Open();

            {
                OleDbCommand cmd2 = new OleDbCommand("UPDATE deliverychalan SET Status=@Status WHERE DCID= '" + comboBox1.Text + "'", mc2.conn);
                cmd2.Parameters.AddWithValue("@Status", "Close");
                cmd2.ExecuteNonQuery();
            }

            MessageBox.Show("Sell Invoice has been Created..!!");
        }
    }
}
