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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int count = 1;
            int i = 0;
            while (i < len)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
                i++;
            }
            label1.Text = "Количество слов = " + count.ToString();
        }
    }
}
