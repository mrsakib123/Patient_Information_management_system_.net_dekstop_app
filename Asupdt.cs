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
    public partial class Asupdt : Form
    {
        public Asupdt()
        {
            InitializeComponent();
        }
       


        private void fnupdate()
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            SqlCommand thisCommand = sv.thisConnection.CreateCommand();
            thisCommand.CommandText = "update Assistant set assistant_name = '" + textBox1.Text + "'  , mobile_numb='" + textBox6.Text + "'  , password='" + textBox3.Text + "' , c_password='" + textBox2.Text + "', username='" + textBox5.Text + "'  where assistant_id= '" + textBox4.Text + "'      ";
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

        private void Asupdt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox2.Text)
            {
                fnupdate();
            }
            else
            {
                MessageBox.Show("Password doesnot match");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DcFeatures obback = new DcFeatures();
            obback.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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
