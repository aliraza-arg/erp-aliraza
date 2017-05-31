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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pC_DBDataSet.POProducts' table. You can move, or remove it, as needed.
            this.pOProductsTableAdapter.Fill(this.pC_DBDataSet.POProducts);
            myconnection mc = new myconnection();
            mc.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select POID from PO;", mc.conn);
            OleDbDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["POID"]);

            }
            mc.conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*myconnection mc1 = new myconnection();
            mc1.conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from POProducts where POID= '" + comboBox1.Text + "';", mc1.conn);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                dataGridView1.Columns= dr1["PModel"].ToString();
                this.dataGridView1.PQty = dr1["PQty"].ToString();




            }
            mc1.conn.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconnection mc = new myconnection();
            mc.conn.Open();

            {


                OleDbCommand cmd = new OleDbCommand("update PO SET Approve = '" + this.comboBox2.Text + "' where POID='" + this.comboBox1.Text + "';", mc.conn);
                cmd.ExecuteReader();
                
            }

            myconnection mc1 = new myconnection();
            mc1.conn.Open();

            {


                OleDbCommand cmd1 = new OleDbCommand("update PO SET Status = '" + this.comboBox3.Text + "' where POID='" + this.comboBox1.Text + "';", mc1.conn);
                cmd1.ExecuteReader();
                MessageBox.Show("Status successfully updated");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}