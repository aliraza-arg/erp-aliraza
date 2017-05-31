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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select GRNID from GRN where Status='Open';", mc.conn);
            OleDbDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["GRNID"]);

            }
            mc.conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from GRN where GRNID= '" + comboBox1.Text + "';", mc1.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                this.textBox1.Text = dr1["TotalAmount"].ToString();
                this.textBox2.Text = dr1["DDate"].ToString();
                this.textBox3.Text = dr1["GRDate"].ToString();
                this.textBox5.Text = dr1["VName"].ToString();
            }
            mc1.conn.Close();

            myconnection mc2 = new myconnection();
            mc2.conn.Open();
            OleDbCommand cmd2 = new OleDbCommand("select * from Vendor where VName= '" + textBox5.Text + "';", mc2.conn);
            OleDbDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                this.textBox4.Text = dr2["VID"].ToString();
                this.textBox6.Text = dr2["CPName"].ToString();
                this.textBox7.Text = dr2["CPPH"].ToString();
                
            }
            mc2.conn.Close();



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            /*if (textBox5.Text == "Lifo sales")
            {

                textBox4.Text = "01".ToString();

            }

            if (textBox5.Text == "RAD enterprise")
            {

                textBox4.Text = "02".ToString();

            }

            if (textBox5.Text == "Blue sales")
            {

                textBox4.Text = "03".ToString();

            }

            if (textBox5.Text == "ROC HR")
            {

                textBox4.Text = "04".ToString();

            }*/
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            /*if (textBox4.Text == "01")
            {

                textBox6.Text = "Zafar Imam".ToString();

            }

            if (textBox4.Text == "02")
            {

                textBox6.Text = "Najaf".ToString();

            }

            if (textBox4.Text == "03")
            {

                textBox6.Text = "Haider".ToString();

            }

            if (textBox4.Text == "04")
            {

                textBox6.Text = "Nazar".ToString();

            }*/
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            /*if (textBox6.Text == "Zafar Imam")
            {

                textBox7.Text = "512016513".ToString();

            }

            if (textBox6.Text == "Najaf")
            {

                textBox7.Text = "321321234".ToString();

            }

            if (textBox6.Text == "Haider")
            {

                textBox7.Text = "321653352".ToString();

            }

            if (textBox6.Text == "Nazar")
            {

                textBox7.Text = "415215432".ToString();

            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();

            OleDbCommand cmd = new OleDbCommand("insert into Invoice(GRNID,AmountPayable,DDate,GRDate,VendorID,VendorName,ContectPerson,CPPH)values(@GRNID,@AmountPayable,@DDate,@GRDate,@VendorID,@VendorName,@ContectPerson,@CPPH);", mc.conn);
            cmd.Parameters.AddWithValue("@GRNID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@AmountPayable", textBox1.Text);
            cmd.Parameters.AddWithValue("@DDate", textBox2.Text);
            cmd.Parameters.AddWithValue("@GRDate", textBox3.Text);
            cmd.Parameters.AddWithValue("@VendorID", textBox4.Text);
            cmd.Parameters.AddWithValue("@VendorName", textBox5.Text);
            cmd.Parameters.AddWithValue("@ContectPerson", textBox6.Text);
            cmd.Parameters.AddWithValue("@CPPH", textBox7.Text);
            

            cmd.ExecuteNonQuery();
            mc.conn.Close();


            myconnection mc2 = new myconnection();
            mc2.conn.Open();

            {
                OleDbCommand cmd2 = new OleDbCommand("UPDATE GRN SET Status=@Status WHERE GRNID= '" + comboBox1.Text + "'", mc2.conn);
                cmd2.Parameters.AddWithValue("@Status", "Close");
                cmd2.ExecuteNonQuery();
            }

            MessageBox.Show("Invoice has been Created..!!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
