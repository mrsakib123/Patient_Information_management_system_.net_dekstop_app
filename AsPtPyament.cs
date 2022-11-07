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
    public partial class AsPtPyament : Form
    {
        public AsPtPyament()
        {
            InitializeComponent();
        }
        

        private void check()
        {
            try
            {

                connection obcn = new connection();
                obcn.thisConnection.Open();
                SqlCommand thisCommand = new SqlCommand();
                thisCommand.Connection = obcn.thisConnection;
                thisCommand.CommandText = "SELECT * FROM patient_info_A WHERE patient_id='" + textBox5.Text + "' ";
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PatientBx obback = new PatientBx();
            obback.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsFeatures obback = new AsFeatures();
            obback.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AsPtOldent obback = new AsPtOldent(textBox5.Text);
            obback.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AsPtRecord obback = new AsPtRecord(textBox5.Text);
            obback.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AsPtUpdt obback = new AsPtUpdt(textBox5.Text);
            obback.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }
    }
}
