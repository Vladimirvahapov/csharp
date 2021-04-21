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
    public partial class Form9 : Form
    {
        public Form9()
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
            int c = 0;
            int j = 0;
            string arr = ("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            while (i < len)
            {
                for(j = 0; j < arr.Length;)
                {
                    if (str[i] == arr[j])
                    {
                        c++;
                        break;
                    }
                    else j++;
                }
                j = 0;
                i++;
            }
            label1.Text = "Количество русских букв: " + c.ToString();
        }
    }
}
