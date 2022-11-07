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
    public partial class DcFeatures : Form
    {
        
        public DcFeatures()
        {
            InitializeComponent();
            
        }
        public DcFeatures(string na)
        {
            InitializeComponent();
           


            //MessageBox.Show("Log In SuccessFully");


            try
            {
                connection sv = new connection();
                sv.thisConnection.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(" SELECT * FROM Register WHERE gmail='" + na + "' ", sv.thisConnection);
                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);

                DataTable dtbl = new DataTable();
                thisAdapter.Fill(dtbl);
                //dataGridView1.DataSource = dtbl;
                foreach (DataRow dr in dtbl.Rows)
                {
                    textBox7.Text = dr["fist_name"].ToString();
                }
                sv.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



           

        }
        
        




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            DcLogin obback = new DcLogin();
            obback.Show();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AsCreate obback = new AsCreate();
            obback.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AsDelete obback = new AsDelete();
            obback.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Asupdt obback = new Asupdt();
            obback.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PtBook obback = new PtBook();
            obback.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DcPtDlt obback = new DcPtDlt();
            obback.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DcPtUpdt obback = new DcPtUpdt();
            obback.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DcSrchBox obback = new DcSrchBox();
            obback.Show();
            this.Hide();
        }
    }
}
