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
    public partial class AsSrchBox : Form
    {
        public AsSrchBox()
        {
            InitializeComponent();
        }

       

        int asrcbox;


        private void partshowPboxId()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_box WHERE patient_id='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowPboxName()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_box WHERE patient_name='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowPrecordId()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_A WHERE patient_id='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowPrecordName()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_A WHERE patient_name='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowPrecordage()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_A WHERE age='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowPrecordGmail()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_A WHERE gmail='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowPrecordDate()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_A WHERE running_date='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowPrecordBirDate()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_A WHERE birthday_date='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowPrecordgender()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_A WHERE gender='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowPrecordAmount()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_A WHERE amount='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowPrecordCurraddress()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_A WHERE current_address='" + textBox5.Text + "' ", sv.thisConnection);
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


        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            asrcbox = 1;
        }

        private void AsSrchBox_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (asrcbox==1)
            {
                if (comboBox1.Text == "Id")
                {
                    partshowPboxId();
                }
                else if (comboBox1.Text == "Name")
                {
                    partshowPboxName();
                }
                else
                {

                }
            }
            else if(asrcbox == 2)
            {
                if (comboBox2.Text == "Id")
                {
                    partshowPrecordId();
                }
                else if (comboBox2.Text == "Name")
                {
                    partshowPrecordName();
                }
                else if (comboBox2.Text == "Age")
                {
                    partshowPrecordage();
                }
                else if (comboBox2.Text == "gmail")
                {
                    partshowPrecordGmail();
                }
                else if (comboBox2.Text == "Current Address")
                {
                    partshowPrecordCurraddress();
                }
                else if (comboBox2.Text == "Date")
                {
                    partshowPrecordDate();
                }
                else if (comboBox2.Text == "Birthday Date")
                {
                    partshowPrecordBirDate();
                }
                else if (comboBox2.Text == "Gender")
                {
                    partshowPrecordgender();
                }
                else if (comboBox2.Text == "Amount")
                {
                    partshowPrecordAmount();
                }
                else if (comboBox2.Text == "Mobile Number")
                {
                    partshowPrecordAmount();
                }


                else
                {

                }
            }
            else
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            asrcbox = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AsFeatures obback = new AsFeatures();
            obback.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";

            radioButton1.Checked = false;
            radioButton14.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
    }
}
