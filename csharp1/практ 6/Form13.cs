using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практ_6
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s, s0;
            s0 = "";
            String[] ss = listBox1.Text.Split(' ');
            for (int i = 0; i < ss.Count(); i++)
            {
                s = ss[i].Substring(1, ss[i].Length-1);
                s0 += (s + " ");
            }
            listBox1.Items.Add(s0);
        }
    }
}
