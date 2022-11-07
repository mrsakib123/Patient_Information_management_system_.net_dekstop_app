using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Patient_Information_Storage_System
{
    public partial class AsCreate : Form
    {
        public AsCreate()
        {
            InitializeComponent();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void createnew()
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM Assistant", sv.thisConnection);
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "Assistant");
            DataRow thisRow = thisDataSet.Tables["Assistant"].NewRow();
            try
            {

                thisRow["assistant_id"] = textBox4.Text;
                thisRow["assistant_name"] = textBox1.Text;              
                thisRow["password"] = textBox3.Text;
                thisRow["c_password"] = textBox2.Text;
                thisRow["mobile_numb"] = textBox6.Text;
                thisRow["username"] = textBox5.Text;
                
                thisDataSet.Tables["Assistant"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "Assistant");
                MessageBox.Show("Succesfully Created");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sv.thisConnection.Close();
        }

        private void fullshow()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM Assistant", sv.thisConnection);
                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
                DataTable dtbl = new DataTable();
                thisAdapter.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                sv.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                createnew();
            }
            else
            {
                MessageBox.Show("Password doesn't match\nTry gain");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fullshow();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DcFeatures obback = new DcFeatures();
            obback.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
