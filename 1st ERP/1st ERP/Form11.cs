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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select SOID from SO where status='Open';", mc.conn);
            OleDbDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["SOID"]);

            }
            mc.conn.Close();

            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd = new OleDbCommand("select CName from Customer;", mc1.conn);
            OleDbDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["CName"]);

            }
            mc1.conn.Close();
        }

        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from SOProducts where SOID= '" + comboBox1.Text + "';", mc1.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                this.textBox1.Text = dr1["pmodel"].ToString();
                this.textBox2.Text = dr1["pqty"].ToString();
            }
            mc1.conn.Close();


            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from SO where SOID= '" + comboBox1.Text + "';", mc.conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.textBox4.Text = dr["sdate"].ToString();

            }
            mc.conn.Close();


            if (textBox1.Text == "a202")
            {

                textBox6.Text = "3000".ToString();

            }

            if (textBox1.Text == "b324")
            {

                textBox6.Text = "2400".ToString();

            }

            if (textBox1.Text == "g325")
            {

                textBox6.Text = "2313".ToString();

            }

            if (textBox1.Text == "p664")
            {

                textBox6.Text = "7543".ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox2.Text);
            double b = Convert.ToInt32(textBox6.Text);
            textBox7.Text = ((a * b).ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select count(DCID) from deliverychalan where cname='" + comboBox2.Text + "'", mc.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                c++;
            }
            if (comboBox2.Text == "STU Pharma")
            {
                textBox3.Text = "stu-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox2.Text == "electro nazi")
            {
                textBox3.Text = "elec-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox2.Text == "A&B Org.")
            {
                textBox3.Text = "a&b-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox2.Text == "SHAMS OIL")
            {
                textBox3.Text = "sh-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            mc.conn.Close();

            textBox5.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();

            OleDbCommand cmd = new OleDbCommand("insert into dcproducts(DCID,pmodel,pqty)values(@DCID,@pmodel,@pqty);", mc.conn);
            cmd.Parameters.AddWithValue("@DCID", textBox3.Text);
            cmd.Parameters.AddWithValue("@pmodel", textBox1.Text);
            cmd.Parameters.AddWithValue("@pqty", textBox2.Text);
            cmd.ExecuteNonQuery();
            mc.conn.Close();
            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into deliverychalan(DCID,SOID,status,cname,ddate,dcdate,tamount)values(@DCID,@SOID,@status,@cname,@ddate,@dcdate,@tamount);", mc1.conn);
            cmd1.Parameters.AddWithValue("@DCID", textBox3.Text);
            cmd1.Parameters.AddWithValue("@SOID", comboBox1.Text);
            cmd1.Parameters.AddWithValue("@status", comboBox3.Text);
            cmd1.Parameters.AddWithValue("@cname", comboBox2.Text);
            cmd1.Parameters.AddWithValue("@ddate", textBox4.Text);
            cmd1.Parameters.AddWithValue("@dcdate", textBox5.Text);
            cmd1.Parameters.AddWithValue("@tamount", textBox7.Text);
            cmd1.ExecuteNonQuery();
            mc1.conn.Close();
            myconnection mc2 = new myconnection();
            mc2.conn.Open();

            {
                OleDbCommand cmd2 = new OleDbCommand("UPDATE SO SET Status=@Status WHERE SOID= '" + comboBox1.Text + "'", mc2.conn);
                cmd2.Parameters.AddWithValue("@Status", "Close");
                cmd2.ExecuteNonQuery();
            }
            MessageBox.Show("Delivery Chalan has been Created..!!");
        }
    }
}
