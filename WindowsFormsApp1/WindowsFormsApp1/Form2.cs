using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            string[] arr = str.Split(' ');
            string c = " ";
            string c1 = " ";
            string c2 = "";
            for (int i = 0; i < arr.Count(); i++)
            {
                c = arr[i].Substring(0, 1).ToUpper();
                arr[i] = c + arr[i].Substring(1, arr[i].Length - 1) + c1;
                c2 += arr[i];
            }
            label1.Text = "" +(c2);

        }



    }

}

    

