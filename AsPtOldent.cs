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
    public partial class AsPtOldent : Form
    {
        public AsPtOldent()
        {
            InitializeComponent();
        }

        string aspold;
      

        public AsPtOldent(string va1)
        {
            InitializeComponent();
            //MessageBox.Show("This is a Old Patient");
            textBox5.Text = va1;
           


            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_A WHERE patient_id='" + va1 + "' ", sv.thisConnection);
                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
                DataTable dtbl = new DataTable();
                thisAdapter.Fill(dtbl);
                //dataGridView1.DataSource = dtbl;
                foreach (DataRow dr in dtbl.Rows)
                {
                    //textBox5.Text = dr["patient_id"].ToString();
                    textBox1.Text = dr["patient_name"].ToString();
                    textBox2.Text = dr["mobile_number"].ToString();
                    textBox3.Text = dr["gmail"].ToString();
                    textBox6.Text = dr["age"].ToString();
                    textBox4.Text = dr["current_address"].ToString();
                    textBox7.Text = dr["amount"].ToString();              
                   // textBox7.Text = dr["gender"].ToString();
                    
                }
                sv.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void createnew()
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM patient_info_A", sv.thisConnection);
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "patient_info_A");
            DataRow thisRow = thisDataSet.Tables["patient_info_A"].NewRow();
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
                thisRow["gender"] = aspold;

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
        private void button2_Click(object sender, EventArgs e)
        {
            createnew();
        }
        


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            aspold = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            aspold = "female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            aspold = "other";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsPtPyament obback = new AsPtPyament();
            obback.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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
