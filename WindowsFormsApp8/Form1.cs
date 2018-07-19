using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (listBox1.Items.Count==0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
          

            if (listBox2.Items.Count==0)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }
            listBox1.Items.Clear();

            if (listBox1.Items.Count == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;

            }
            if (listBox2.Items.Count != 0)
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
                list.Add(item.ToString());
            }

            foreach (var item in list)
            {
                listBox1.Items.Remove(item);
            }
            if (listBox1.Items.Count == 0)
            {
                button2.Enabled = false;
                button1.Enabled = false;
               
            }
            if (listBox2.Items.Count!=0)
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Add(item);
            }
            listBox2.Items.Clear();

            if (listBox2.Items.Count == 0)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }

            if (listBox1.Items.Count!=0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            foreach (var item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(item);
                list.Add(item.ToString());
            }

            foreach (var item in list)
            {
                listBox2.Items.Remove(item);
            }



            if (listBox2.Items.Count == 0)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
            if (listBox1.Items.Count != 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }
    }
}
