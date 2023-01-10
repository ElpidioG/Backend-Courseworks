using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listB.Items.Add("Manzana");
            listB.Items.Add("Guayaba");
            listB.Items.Add("Pera");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            listB.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
            textBox1.Focus();
        }

        private void lablist_Click(object sender, EventArgs e)
        {
            
        }

        private void listB_SelectedIndexChanged(object sender, EventArgs e)
        {
            lablist.Text = (string)listB.Items[listB.SelectedIndex] ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int list = listB.SelectedIndex;
            if( list <= 0)
            {
                listB.Items.RemoveAt(list);
            }
        }
    }
}
