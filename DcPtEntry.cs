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
    public partial class DcPtEntry : Form
    {
        public DcPtEntry()
        {
            InitializeComponent();
        }
        public DcPtEntry(string ha,string ha1)
        {
           
            InitializeComponent();
            // MessageBox.Show("Welcome Entry");
            //textBox7.Text = pa;
            textBox11.Text = ha;
            textBox10.Text = ha1;
        }



        string regh, regg;

        private void createnew()
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM patient_info_D", sv.thisConnection);
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "patient_info_D");
            DataRow thisRow = thisDataSet.Tables["patient_info_D"].NewRow();
            try
            {

                thisRow["patient_id"] = textBox11.Text;
                thisRow["patient_name"] = textBox10.Text;
                thisRow["age"] = textBox1.Text;
                thisRow["blood_group"] = textBox3.Text;
                thisRow["heart_problem"] = regh;
                thisRow["gender"] = regg;
                thisRow["running_date"] = dateTimePicker1.Text;
                thisDataSet.Tables["patient_info_D"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "patient_info_D");
                MessageBox.Show("Succesfully Created");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sv.thisConnection.Close();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            regh = "yes";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            regh = "no";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            regg = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            regg = "female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            regg = "other";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckUpbok obback = new CheckUpbok(textBox11.Text, textBox10.Text);
            obback.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createnew();
        }
    }
}
