using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using etf.cfactor.zd130033d.Klase;

namespace etf.cfactor.zd130033d
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btAddRule_Click(object sender, EventArgs e)
        {
            // Get rule from textbox.
            //
            String rule = tbRule.Text;
            String[] paramsVal;
            try {
                Parser.Check(rule, out paramsVal);
            }
            catch (Error er)
            {
                MessageBox.Show(er.ToString());
                return;
            }

            listBoxRules.Items.Add(rule);
            

            
        }
    }
}
