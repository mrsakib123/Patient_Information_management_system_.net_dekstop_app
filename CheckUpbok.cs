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
    public partial class CheckUpbok : Form
    {
        public CheckUpbok()
        {
            InitializeComponent();
        }

        public CheckUpbok(string pa,string za)
        {
            InitializeComponent();
            //MessageBox.Show("Succesfully Entry");
            textBox1.Text = pa;
            textBox7.Text = za;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            PtBSntmEnry obback = new PtBSntmEnry(textBox1.Text, textBox7.Text);
            obback.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PtBRptEnry obback = new PtBRptEnry(textBox1.Text, textBox7.Text);
            obback.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PtBPrsEnry obback = new PtBPrsEnry(textBox1.Text, textBox7.Text);
            obback.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Patient_login obback = new Patient_login();
            obback.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DcPtEntry obback = new DcPtEntry(textBox1.Text, textBox7.Text);
            obback.Show();
            this.Hide();
        }
    }
}
