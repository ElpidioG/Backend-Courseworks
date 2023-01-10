using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox5a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radiosandwich_CheckedChanged(object sender, EventArgs e)
        {
            if(radiosandwich.Checked==true)
            {
                textBox1.Text = "150";
                    }
        }

        private void radiohamburguesa_CheckedChanged(object sender, EventArgs e)
        {
            if (radiohamburguesa.Checked == true)
            {
                textBox1.Text = "220";
            }
        }

        private void radionuggets_CheckedChanged(object sender, EventArgs e)
        {
            if (radionuggets.Checked == true)
            {
                textBox1.Text = "260";
            }
        }

        private void butaceptar_Click(object sender, EventArgs e)
        {
            labeltotal.Visible = true;
            int monto = Convert.ToInt32(textBox1.Text);
            if(checkpapa.Checked==true)
            {
                monto += 40;

            }
            if (checkrefresco.Checked == true)
            {
                monto += 30;

            }
            if (checkpostre.Checked == true)
            {
                monto += 60;

            }

            labeltotal.Text = "El precio a pagar es: " + Convert.ToString(monto);
        }

        private void butcancel_Click(object sender, EventArgs e)
        {
            radiohamburguesa.Checked = false;
            radionuggets.Checked = false;
            radiosandwich.Checked = false;

            checkpapa.Checked = false;
            checkpostre.Checked = false;
            checkrefresco.Checked = false;
            textBox1.Text = "";
            labeltotal.Visible = false;
        }

        private void butcerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
