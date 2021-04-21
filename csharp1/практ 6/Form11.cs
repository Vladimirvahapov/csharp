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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int i = 0;
            int j = 0;
            string c1 = "";
            string arr = ("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            while (i < len)
            {
                for (j = 0; j < arr.Length;)
                {
                    if (str[i] == arr[j])
                    {
                        c1 += str[i];
                        break;
                    }
                    else j++;
                }
                j = 0;
                i++;
            }
            label1.Text = c1.ToString();
        }
    }
}
