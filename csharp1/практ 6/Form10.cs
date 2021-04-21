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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int i = 0;
            int j = 0;
            string arr1 = ("1234567890");
            string arr2 = (".,:;!?");
            string arr3 = ("абвгдеёжзийклмнопрстуфхцчшщъыьэюя ");
            string c1 = "";
            string c2 = "";
            string c3 = "";
            while (i < len)
            {
                for (j = 0; j < arr1.Length;)
                {
                    if (str[i] == arr1[j])
                    {
                        c1 += str[i];
                        break;
                    }
                    else j++;

                }
                j = 0;
                for (j = 0; j < arr2.Length;)
                {
                    if (str[i] == arr2[j])
                    {
                        c2 += str[i];
                        break;
                    }
                    else j++;
                }
                j = 0;
                for (j = 0; j < arr3.Length;)
                {
                    if (str[i] == arr3[j])
                    {
                        c3 += str[i];
                        
                    }
                    j++;
                }
                j = 0;
                i++;
            }
            listBox1.Items.Add(c1);
            listBox1.Items.Add(c2);
            listBox1.Items.Add(c3);
        }
    }
}
