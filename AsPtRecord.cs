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
    public partial class AsPtRecord : Form
    {
        public AsPtRecord()
        {
            InitializeComponent();
        }
        public AsPtRecord(string k1)
        {
            InitializeComponent();
            textBox5.Text = k1;
           
        }

     
        string aspr;


        private void button2_Click(object sender, EventArgs e)
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM Patient_info_A", sv.thisConnection);
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "Patient_info_A");
            DataRow thisRow = thisDataSet.Tables["Patient_info_A"].NewRow();
            try
            {

                thisRow["Patient_id"] = textBox5.Text;
                thisRow["patient_name"] = textBox1.Text;
                thisRow["mobile_number"] = textBox2.Text;
                thisRow["gmail"] = textBox3.Text;
                thisRow["age"] = textBox6.Text;
                thisRow["current_address"] = textBox4.Text;
                thisRow["amount"] = textBox7.Text;
                thisRow["birthday_date"] = dateTimePicker1.Text;
                thisRow["running_date"] = dateTimePicker2.Text;
                thisRow["gender"] = aspr;

                thisDataSet.Tables["Patient_info_A"].Rows.Add(thisRow);

                thisAdapter.Update(thisDataSet, "Patient_info_A");
                MessageBox.Show("Submitted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sv.thisConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsPtPyament obback = new AsPtPyament();
            obback.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            aspr = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            aspr = "Female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            aspr = "Other";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
    }
}
