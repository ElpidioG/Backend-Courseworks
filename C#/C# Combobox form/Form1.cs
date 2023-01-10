using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboxbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBnombre.Items.Add("Dinclo");
            comboBnombre.Items.Add("Raymundo");
            comboBnombre.Items.Add("Juani");
            comboBnombre.Items.Add("Pechu");
        }

        private void butagregar_Click(object sender, EventArgs e)
        {
            comboBnombre.Items.Add(textBadd);
           // textBadd.Text = "";
        }

        private void butcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butprint_Click(object sender, EventArgs e)
        {
            int indice = comboBnombre.SelectedIndex;
            label1.Text = indice.ToString();
            label2.Text = comboBnombre.Items[indice].ToString();
        }

        private void comboBnombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBnombre.SelectedIndex;
            label3.Text = indice.ToString();
            label4.Text = comboBnombre.Items[indice].ToString();
        }

        private void comboBnombre_Click(object sender, EventArgs e)
        {
            textBadd.Text = "hice clic";
        }

        private void textBadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBadd_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("El mouse esta aqui");
        }
    }
}
