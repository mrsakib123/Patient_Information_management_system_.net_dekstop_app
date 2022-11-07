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
    public partial class DcPAtienBx : Form
    {
        public DcPAtienBx()
        {
            InitializeComponent();
           
        }
        

        private void fullshow()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM patient_box", sv.thisConnection);
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

        private void partshow()
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

        private void check()
        {
            try
            {

                connection obcn = new connection();
                obcn.thisConnection.Open();
                SqlCommand thisCommand = new SqlCommand();
                thisCommand.Connection = obcn.thisConnection;
                thisCommand.CommandText = "SELECT * FROM patient_box WHERE patient_id='" + textBox5.Text + "' ";
                SqlDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    MessageBox.Show("Found");
                }
                else
                {
                    MessageBox.Show("Not Found");
                }

                obcn.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fullshow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            partshow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PtBook obback = new PtBook();
            obback.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }
    }
}
