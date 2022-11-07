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
    public partial class DcPtUpdt : Form
    {
        public DcPtUpdt()
        {
            InitializeComponent();
        }
        

        private void fnupdate()
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            SqlCommand thisCommand = sv.thisConnection.CreateCommand();
            thisCommand.CommandText = "update patient_info_D set patient_name = '" + textBox7.Text + "'  , blood_group='" + textBox3.Text + "'  , age='" + textBox1.Text + "'    where patient_id= '" + textBox2.Text + "'      ";
            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;

            try
            {
                thisCommand.ExecuteNonQuery();
                MessageBox.Show("Updated");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            sv.thisConnection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fnupdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DcFeatures obback = new DcFeatures();
            obback.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";
        }
    }
}
