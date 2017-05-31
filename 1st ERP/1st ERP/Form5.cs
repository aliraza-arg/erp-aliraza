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
    public partial class Form5 : Form
    {
        string[] prds = new string[50];
        int[] qty = new int[50];
        int[] rst = new int[50];
        int counter = 0;
    
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.textBox10.ScrollBars = ScrollBars.Both;
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select GrpName from CusGroup;", mc.conn);
            OleDbDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["GrpName"]);

            }
            mc.conn.Close();


            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd = new OleDbCommand("select VID from Vendor;", mc1.conn);
            OleDbDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["VID"]);

            }
            mc1.conn.Close();


            myconnection mc2 = new myconnection();
            mc2.conn.Open();
            OleDbCommand cmd2 = new OleDbCommand("select PModel from Products;", mc2.conn);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox3.Items.Add(dr2["PModel"]);

            }
            mc2.conn.Close();

            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 1;
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select count(poid) from po where vdept='" + comboBox2.Text + "'", mc.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                c++;
            }
            if (comboBox1.Text == "Consumer")
            {
                textBox9.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            if (comboBox1.Text == "HR")
            {
                textBox9.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            if (comboBox1.Text == "Marketing")
            {
                textBox9.Text = "Mar-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            if (comboBox1.Text == "Sales")
            {
                textBox9.Text = "Sal-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            mc.conn.Close();
                        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from Vendor where VID= '" + comboBox2.Text + "';", mc1.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                this.textBox1.Text = dr1["VName"].ToString();
                this.textBox2.Text = dr1["VGroup"].ToString();
                this.textBox3.Text = dr1["CPName"].ToString();
                this.textBox4.Text = dr1["CPPH"].ToString();
                

            }
            mc1.conn.Close();
        
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from Products where PModel= '" + comboBox3.Text + "';", mc1.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                this.textBox6.Text = dr1["PName"].ToString();
                this.textBox7.Text = dr1["BasePrice"].ToString();
                


            }
            mc1.conn.Close();
        
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox7.Text);
            double b = Convert.ToInt32(textBox8.Text);
            textBox10.Text += "Product I.D=" + textBox6.Text + Environment.NewLine;
            textBox10.Text += "Product Qantity=" + textBox8.Text + Environment.NewLine + "Total Of one Product=" + ((a * b).ToString()) + Environment.NewLine;
            prds[counter] = textBox6.Text;
            qty[counter] = Convert.ToInt32(textBox8.Text);
            counter++;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into PO(POID,DDate,VID,VName,VDept,VContectPerson,VCPPH)values(@POID,@DDate,@VID,@VName,@VDept,@VContectPerson,@VCPPH);", mc.conn);
            cmd.Parameters.AddWithValue("@POID", textBox9.Text);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@VID", comboBox2.Text);
            cmd.Parameters.AddWithValue("@VName", textBox1.Text);
            cmd.Parameters.AddWithValue("@VDept", textBox2.Text);
           
            cmd.Parameters.AddWithValue("@VContectPerson", textBox3.Text);
            cmd.Parameters.AddWithValue("@VCPPH", textBox4.Text);


            cmd.ExecuteNonQuery();
            mc.conn.Close();


            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into POProducts(POID,PModel,PQty)values(@POID,@PModel,@PQty);", mc1.conn);
            cmd1.Parameters.AddWithValue("@POID", textBox9.Text);
            cmd1.Parameters.AddWithValue("@PModel", comboBox3.Text);
            cmd1.Parameters.AddWithValue("@PQty", textBox8.Text);

            cmd1.ExecuteNonQuery();
            mc1.conn.Close();



            MessageBox.Show("New Purchase Order has been Created..!!");
        }
    }
}
