using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int j = 0;
        private string prev;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] count = new string[] { "10","9", "8", "7", "6", "5", "4", "3", "2", "1", "nul" };
            if (j == 10) return;
            prev = count[j++];
            prev += " chislo";
            listBox1.Items.Add(prev);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] count = new string[] { "10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "nul" };
            if (j == -1) return;
            prev = count[j--];
            prev += " chislo";
            listBox1.Items.Add(prev);
        }
    }
}
