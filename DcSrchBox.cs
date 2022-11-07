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
    public partial class DcSrchBox : Form
    {
        public DcSrchBox()
        {
            InitializeComponent();
        }
       


        int dcrcbox;


        private void partshowAsId()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM Assistant WHERE assistant_id='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowAsName()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM Assistant WHERE assistant_name='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowAsmobileNo()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM Assistant WHERE mobile_numb='" + textBox5.Text + "' ", sv.thisConnection);
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
        private void partshowAsusername()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM Assistant WHERE username='" + textBox5.Text + "' ", sv.thisConnection);
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



        private void partshowPatId()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_D WHERE patient_id='" + textBox5.Text + "' ", sv.thisConnection);
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

        private void partshowPatName()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_D WHERE patient_name='" + textBox5.Text + "' ", sv.thisConnection);
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

        private void partshowPatage()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_D WHERE age='" + textBox5.Text + "' ", sv.thisConnection);
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

        private void partshowPatbloodgrp()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_D WHERE blood_group='" + textBox5.Text + "' ", sv.thisConnection);
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

        private void partshowPathertprblm()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_D WHERE heart_problem='" + textBox5.Text + "' ", sv.thisConnection);
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

        private void partshowPatdate()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_D WHERE running_date='" + textBox5.Text + "' ", sv.thisConnection);
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

        private void partshowPatgender()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_D WHERE gender='" + textBox5.Text + "' ", sv.thisConnection);
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










        private void button6_Click(object sender, EventArgs e)
        {
            if (dcrcbox == 1)
            {
                if (comboBox1.Text == "Id")
                {
                    partshowAsId();
                }
                else if (comboBox1.Text == "Name")
                {
                    partshowAsName();
                }
                else if (comboBox1.Text == "Mobile_Number")
                {
                    partshowAsmobileNo();
                }
                else if (comboBox1.Text == "Username")
                {
                    partshowAsusername();
                }
               
                else
                {

                }
            }
            else if (dcrcbox == 2)
            {
                if (comboBox2.Text == "Id")
                {
                   partshowPatId();
                }
                else if (comboBox2.Text == "Name")
                {
                    partshowPatName();
                }
                else if (comboBox2.Text == "Age")
                {
                    partshowPatage();
                }
                else if (comboBox2.Text == "Blood_Groupe")
                {
                    partshowPatbloodgrp();
                }
                else if (comboBox2.Text == "Heart_problem")
                {
                    partshowPathertprblm();
                }
                else if (comboBox2.Text == "Date")
                {
                    partshowPatdate();
                }
                
                else if (comboBox2.Text == "Gender")
                {
                    partshowPatgender();
                }
                

                else
                {

                }
            }
            else
            {

            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            dcrcbox = 1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dcrcbox = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DcFeatures obback = new DcFeatures();
            obback.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton14.Checked = false;
        }
    }
}
