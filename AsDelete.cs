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
    public partial class AsDelete : Form
    {
        public AsDelete()
        {
            InitializeComponent();
        }
       

        int asdlt;
      

        private void fullshow()
        {
            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM Assistant", sv.thisConnection);
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
                thisCommand.CommandText = "SELECT * FROM Assistant WHERE assistant_id='" + textBox5.Text + "' ";
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

        private void fndelete()
        {
            connection con = new connection();
            con.thisConnection.Open();
            SqlCommand thisCommand1 = con.thisConnection.CreateCommand();
            thisCommand1.CommandText = "delete Assistant where assistant_id= '" + textBox5.Text + "'";
            thisCommand1.Connection = con.thisConnection;
            thisCommand1.CommandType = CommandType.Text;


            try
            {
                thisCommand1.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            con.thisConnection.Close();

        }


        private void button6_Click(object sender, EventArgs e)
        {
            fullshow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure ??\nPlease Click 'Yes' or 'No' and Press 'click' ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (asdlt== 1)
            {
                fndelete();
            }
            else
            {
                MessageBox.Show("Delete Cancel");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            asdlt = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            asdlt = 2;
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
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
