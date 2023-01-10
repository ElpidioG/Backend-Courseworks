using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureboxili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("esta es mi imagen");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "ElPechu" && textBox2.Text == "elpechu12345")
            {
                MessageBox.Show("Bienvenido al sistema, ElPechu", "Bienvenido",MessageBoxButtons.OK);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos, desea reintentar?",
                    "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }
    }
}
