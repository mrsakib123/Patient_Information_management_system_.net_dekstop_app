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
    public partial class DcLogin : Form
    {
        
        public DcLogin()
        {
            InitializeComponent();
        }
       

        private void logincheck()
        {
            
            try
            {
                

                connection obcn = new connection();
                obcn.thisConnection.Open();
                SqlCommand thisCommand = new SqlCommand();
                thisCommand.Connection = obcn.thisConnection;
                thisCommand.CommandText = "SELECT * FROM Register WHERE gmail='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
                SqlDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {


                    //DcFeatures features = new DcFeatures(textBox1.Text);
                    DcFeatures feat = new DcFeatures(textBox1.Text);
                    feat.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("username or password incorrect");
                }

                obcn.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            logincheck();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start1 obback = new Start1();
            obback.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registr obback = new Registr();
            obback.Show();
            this.Hide();
        }
    }
}
