using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inText = textBox1.Text;
            string outText = Convert.ToString(inText[3]) + inText[8] + inText[1] + inText[2] + inText[4] + inText[6] + inText[7] + inText[0] + inText[5];
            textBox2.Text = outText;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string outText = textBox3.Text;
            string inText = Convert.ToString(outText[0]) + outText[13] + outText[14] + outText[3] + outText[11] + outText[6] + outText[5] + outText[8] + outText[7] + outText[10]+ outText[9]+ outText[4]+ outText[12]+ outText[1]+ outText[2]+ outText[15];
            textBox4.Text = inText;
        }
    }
}
