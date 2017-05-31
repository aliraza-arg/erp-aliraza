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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select POID from PO where Status='Open';", mc.conn);
            OleDbDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["POID"]);

            }
            mc.conn.Close();

            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd = new OleDbCommand("select VName from Vendor;", mc1.conn);
            OleDbDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["VName"]);

            }
            mc1.conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from POProducts where POID= '" + comboBox1.Text + "';", mc1.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                this.textBox1.Text = dr1["PModel"].ToString();
                this.textBox2.Text = dr1["PQty"].ToString();
            }
            mc1.conn.Close();


            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from PO where POID= '" + comboBox1.Text + "';", mc.conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.textBox4.Text = dr["DDate"].ToString();
               
            }
            mc.conn.Close();


            if (textBox1.Text == "asdf234")
            {

                textBox6.Text = "12".ToString();
          
            }

            if (textBox1.Text == "eset201")
            {

                textBox6.Text = "2500".ToString();

            }

            if (textBox1.Text == "KG200")
            {

                textBox6.Text = "3000".ToString();

            }

            if (textBox1.Text == "Nor245")
            {

                textBox6.Text = "2000".ToString();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select count(GRNID) from GRN where VName='" + comboBox2.Text + "'", mc.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                c++;
            }
            if (comboBox2.Text == "Lifo sales")
            {
                textBox3.Text = "Lif-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox2.Text == "RAD enterprise")
            {
                textBox3.Text = "RAD-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox2.Text == "Blue sales")
            {
                textBox3.Text = "Blue-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox2.Text == "ROC HR")
            {
                textBox3.Text = "ROC-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            
            mc.conn.Close();

            textBox5.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox2.Text);
            double b = Convert.ToInt32(textBox6.Text);
            textBox7.Text = ((a * b).ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();

            OleDbCommand cmd = new OleDbCommand("insert into GRNProducts(GRNID,PModel,PQty)values(@GRNID,@PModel,@PQty);", mc.conn);
            cmd.Parameters.AddWithValue("@GRNID", textBox3.Text);
            cmd.Parameters.AddWithValue("@PModel", textBox1.Text);
            cmd.Parameters.AddWithValue("@PQty", textBox2.Text);
            cmd.ExecuteNonQuery();
            mc.conn.Close();
            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into GRN(GRNID,BaseDocument,Status,VName,DDate,GRDate,TotalAmount)values(@GRNID,@BaseDocument,@Status,@VName,@DDate,@GRDate,@TotalAmount);", mc1.conn);
            cmd1.Parameters.AddWithValue("@GRNID", textBox3.Text);
            cmd1.Parameters.AddWithValue("@BaseDocument", comboBox1.Text);
            cmd1.Parameters.AddWithValue("@Status", comboBox3.Text);
            cmd1.Parameters.AddWithValue("@VName", comboBox2.Text);
            cmd1.Parameters.AddWithValue("@DDate", textBox4.Text);
            cmd1.Parameters.AddWithValue("@GRDate", textBox5.Text);
            cmd1.Parameters.AddWithValue("@TotalAmount", textBox7.Text);
            cmd1.ExecuteNonQuery();
            mc1.conn.Close();
            myconnection mc2 = new myconnection();
            mc2.conn.Open();

            {
                OleDbCommand cmd2 = new OleDbCommand("UPDATE PO SET Status=@Status WHERE POID= '" + comboBox1.Text + "'", mc2.conn);
                cmd2.Parameters.AddWithValue("@Status", "Close");
                cmd2.ExecuteNonQuery();
            }
            MessageBox.Show("GRN has been Created..!!");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
