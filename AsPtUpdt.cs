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
    public partial class AsPtUpdt : Form
    {
        public AsPtUpdt()
        {
            InitializeComponent();
        }
        public AsPtUpdt(string la)
        {
            InitializeComponent();
            // MessageBox.Show("Log In SuccessFully");
            textBox4.Text = la;
           


            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();


                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM patient_info_A WHERE patient_id='" + la + "' ", sv.thisConnection);

                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);

                DataTable dtbl = new DataTable();
                thisAdapter.Fill(dtbl);
                //dataGridView1.DataSource = dtbl;
                foreach (DataRow dr in dtbl.Rows)
                {
                   // textBox7.Text = dr["patient_id"].ToString();
                    textBox1.Text = dr["patient_name"].ToString();
                    textBox2.Text = dr["mobile_number"].ToString();
                    textBox3.Text = dr["gmail"].ToString();
                    textBox7.Text = dr["amount"].ToString();
                    textBox5.Text = dr["current_address"].ToString();
                    textBox8.Text = dr["age"].ToString();

                }
                sv.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void fnupdate()
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            SqlCommand thisCommand = sv.thisConnection.CreateCommand();
            thisCommand.CommandText = "update patient_info_A set patient_name = '" + textBox1.Text + "'  , mobile_number='" + textBox2.Text + "'  , gmail='" + textBox3.Text + "' , age='" + textBox8.Text + "', current_address='" + textBox5.Text + "', amount='" + textBox7.Text + "'   where patient_id= '" + textBox4.Text + "'      ";
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
            AsFeatures obback = new AsFeatures();
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
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
