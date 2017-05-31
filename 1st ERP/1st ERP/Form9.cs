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
    public partial class Form9 : Form{
        string[] prds = new string[50];
        int[] qty = new int[50];
        int[] rst = new int[50];
        int counter = 0;
    
        public Form9()
        {
            InitializeComponent();
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

        private void Form9_Load(object sender, EventArgs e)
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
            OleDbCommand cmd = new OleDbCommand("select CID from Customer;", mc1.conn);
            OleDbDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["CID"]);

            }
            mc1.conn.Close();


            myconnection mc2 = new myconnection();
            mc2.conn.Open();
            OleDbCommand cmd2 = new OleDbCommand("select pmodel from SellingProducts;", mc2.conn);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox3.Items.Add(dr2["pmodel"]);

            }
            mc2.conn.Close();

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
                textBox9.Text = "Con-sell-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            if (comboBox1.Text == "HR")
            {
                textBox9.Text = "HR-sell-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            if (comboBox1.Text == "Marketing")
            {
                textBox9.Text = "Mar-sell-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            if (comboBox1.Text == "Sales")
            {
                textBox9.Text = "Sal-sell-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            mc.conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from Customer where CID= '" + comboBox2.Text + "';", mc1.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                this.textBox1.Text = dr1["Cname"].ToString();
                this.textBox2.Text = dr1["CGroup"].ToString();
                this.textBox3.Text = dr1["ContectPerson"].ToString();
                this.textBox4.Text = dr1["CPPH"].ToString();


            }
            mc1.conn.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from SellingProducts where pmodel= '" + comboBox3.Text + "';", mc1.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                this.textBox6.Text = dr1["pname"].ToString();
                this.textBox7.Text = dr1["pprice"].ToString();



            }
            mc1.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();
            
            OleDbCommand cmd = new OleDbCommand("insert into SO(SOID,sdate,cid,cname,cdept,con_per,con_per_p)values(@SOID,@sdate,@cid,@cname,@cdept,@con_per,@con_per_p);", mc.conn);
               
            cmd.Parameters.AddWithValue("@SOID", textBox9.Text);
            cmd.Parameters.AddWithValue("@sdate", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@cid", comboBox2.Text);
            cmd.Parameters.AddWithValue("@cname", textBox1.Text);
            cmd.Parameters.AddWithValue("@cdept", textBox2.Text);
            cmd.Parameters.AddWithValue("@con_per", textBox3.Text);
            cmd.Parameters.AddWithValue("@con_per_p", textBox4.Text);
            
            cmd.ExecuteNonQuery();
            mc.conn.Close();

            myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into SOProducts(SOID,pmodel,pqty)values(@SOID,@pmodel,@pqty);", mc1.conn);
            cmd1.Parameters.AddWithValue("@SOID", textBox9.Text);
            cmd1.Parameters.AddWithValue("@pmodel", comboBox3.Text);
            cmd1.Parameters.AddWithValue("@pqty", textBox8.Text);

            cmd1.ExecuteNonQuery();
            mc1.conn.Close();

            MessageBox.Show("New Sell Order has been Created..!!");

        }
    }
}
