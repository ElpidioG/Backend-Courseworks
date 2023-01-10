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
        DialogResult resultado;
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fotologin_MouseClick(object sender, MouseEventArgs e)
        {
            if (textusuario.Text == "ElPechu" && textcontra.Text == "pechu12345" )
            {
                MessageBox.Show("Se ha loggeado correctamente", "Bienvenido", MessageBoxButtons.OK);
                textcontra.Text = "";
                textusuario.Text = "";


                Form2 miform = new Form2();
                miform.Show();
                this.Hide();

   

            }
            else
            {
                
              resultado =  MessageBox.Show("El Usuario o la Contraseña son incorrectas", "Inicio de Sesión Incorrecto", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning   );
                if(resultado == DialogResult.Retry)
                {
                    textcontra.Text = "";
                    textusuario.Text = "";
                }
                else
                {

                }





            }
           
        }

        private void picturelogout_MouseClick(object sender, MouseEventArgs e)
        {
           resultado = MessageBox.Show("¿Estás seguro que deseas salir de la sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                
            }
          
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo);
            {
                if (resultado == DialogResult.Yes)
                {
                    Close();
                }

            }
        }

        private void picturepechu_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Foto del pechu levantado", "El pechu");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
    