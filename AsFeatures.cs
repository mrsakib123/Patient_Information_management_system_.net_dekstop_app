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
    public partial class AsFeatures : Form
    {
        public AsFeatures()
        {
            InitializeComponent();
        }
        public AsFeatures(string ba)
        {
            InitializeComponent();
            //MessageBox.Show("Log In SuccessFully");
            textBox7.Text = ba;

           
        }


        private void button9_Click(object sender, EventArgs e)
        {
            AsLogin obback = new AsLogin();
            obback.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AsSrchBox obback = new AsSrchBox();
            obback.Show();
            this.Hide();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            AsPtDelete obback = new AsPtDelete();
            obback.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AsPtPyament obback = new AsPtPyament();
            obback.Show();
            this.Hide();
        }
    }
}
