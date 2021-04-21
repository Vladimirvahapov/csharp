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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text =" ";
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int i = 0;
            while (i < len)
            {
                if (
                    str[i] == '0' ||
                    str[i] == '1' ||
                    str[i] == '2' ||
                    str[i] == '3' ||
                    str[i] == '4' ||
                    str[i] == '5' ||
                    str[i] == '6' ||
                    str[i] == '7' ||
                    str[i] == '8' ||
                    str[i] == '9'
                    ) {
                    label1.Text += str[i].ToString(); 
                }
                i++;
            }
        }
    }
}
