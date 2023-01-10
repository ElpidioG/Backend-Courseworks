using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butcancelar_Click(object sender, EventArgs e)
        {
            
            butcancelar.Visible = false;
            btwelcome.Enabled = true;
        }

        private void butaceptar_Click(object sender, EventArgs e)
        {
            textnombre.Text = " ";
            butcancelar.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textnombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void labelnombre_Click(object sender, EventArgs e)
        {
            labelnombre.Text = "Nombre";
        }

        private void btwelcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola 5to A");
        }

        private void btwelcome_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hola 5to A");
        }

        private void butcambio_Click(object sender, EventArgs e)
        {
            labelnombre.Text = "Ya cambio";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btwelcome.Text == "Bienvenidos")
            {
                btwelcome.Text = "Welcome";
                butaceptar.Text = "Accept";
                butcambio.Text = "Change";
                butcancelar.Text = "Cancel";
                butedit.Text = "Edit";
                buttraducir.Text = "Translate";
                labelnombre.Text = "Name";
            }
            else
            {
                btwelcome.Text = "Bienvenidos";
                butaceptar.Text = "Aceptar";
                butcambio.Text = "Cambiar";
                butcancelar.Text = "Cancelar";
                butedit.Text = "Editar";
                buttraducir.Text = "Traducir";
                labelnombre.Text = "Nombre";
            }
    

            
        }

        private void butedit_Click(object sender, EventArgs e)
        {
            textnombre.Enabled = true;
            textnombre.Focus();
        }
    }
}
