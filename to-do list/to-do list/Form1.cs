using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do_list
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = " ";
            
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("C:\\users\\vasko\\desktop\\demo.txt");
            foreach (var item in listBox1.Items)
            {
                txt.WriteLine(item.ToString());
            }
            txt.Close();
            MessageBox.Show("File Saved");
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            int i = listBox1.Items.Count - 1;
            listBox1.Items.RemoveAt(i);
            i--;
        }
    }
}
