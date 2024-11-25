using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12AQUIZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (radioButton2.Checked) s++;
            if(checkBox2.Checked) s++;
            if(checkBox4.Checked) s++;
            if(checkBox5.Checked) s++;
            if (checkBox1.Checked || checkBox3.Checked) s = 0;
            MessageBox.Show("Punctaj="+s.ToString());
        }
    }
}
