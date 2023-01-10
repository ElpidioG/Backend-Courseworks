using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace menu1
{
    public partial class Form1 : Form
    {
        double resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void sumarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                resultado = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(resultado);

            }
        }

        private void restarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="" && textBox2.Text != "")
            {
                resultado = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(resultado);

            }
         
        }

        private void multiplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                resultado = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(resultado);

            }
        }

        private void divisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                resultado = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(resultado);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            resultado = 0;
        }
    }
}
