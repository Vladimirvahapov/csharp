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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int count1 = 0;
            int count2 = 0;
            int i = 0;
            while (i < len)
            {
                if (str[i] == '0')
                {
                    count1++;
                }
                else if(str[i] == '1'){
                    count2++;
                }
                i++;
            }
            label1.Text = "Количество 1 = " + count2.ToString();
            label2.Text = "Количество 0 = " + count1.ToString();
        }
    }
}
