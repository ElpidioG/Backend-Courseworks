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
    public partial class Form2 : Form
    {
        DialogResult resultado;
        public Form2()
        {
            InitializeComponent();
        }

        private void picturepechu_Click(object sender, EventArgs e)
        {

        }

        private void picturelogout_Click(object sender, EventArgs e)
        {
            resultado = MessageBox.Show("¿Estás seguro que deseas salir de la sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Form1 miform1 = new Form1();
                miform1.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo);
            {
                if (resultado == DialogResult.Yes)
                {
                    Close();
                }

            }
        }
    }
}
