using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        int nota;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radiopregunta1op1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiopregunta1op2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butenviar1_Click(object sender, EventArgs e)
        {
            if (radiopregunta1op1.Checked == true)
            {
                nota += 20;
                groupBox1.BackColor = Color.LimeGreen;
                labelestado.Text = "Correcto 20/20";
            }
            else
            {
                
                groupBox1.BackColor = Color.Red;
                labelestado.Text = "Incorrecto 0/20";
            }

            groupBox1.Enabled = false;
            
        }

        private void butenviar2_Click(object sender, EventArgs e)
        {
            if (radiopregunta2op1.Checked == true)
            {
                nota += 20;
                groupBox2.BackColor = Color.LimeGreen;
                labelestado2.Text = "Correcto 20/20";
            }
            else
            {
                groupBox2.BackColor = Color.Red;
                labelestado2.Text = "Incorrecto 0/20";
            }

            groupBox2.Enabled = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void butenviar3_Click(object sender, EventArgs e)
        {
            if (radiopregunta3op2.Checked == true)
            {
                nota += 20;
                groupBox3.BackColor = Color.LimeGreen;
                labelestado3.Text = "Correcto 20/20";
            }
            else
            {
                groupBox3.BackColor = Color.Red;
                labelestado3.Text = "Incorrecto 0/20";
            }

            groupBox3.Enabled = false;
        }

        private void butenviar4_Click(object sender, EventArgs e)
        {
            if (radiopregunta4op3.Checked == true)
            {
                nota += 20;
                groupBox4.BackColor = Color.LimeGreen;
                labelestado4.Text = "Correcto 20/20";
            }
            else
            {
                groupBox4.BackColor = Color.Red;
                labelestado4.Text = "Incorrecto 0/20";
            }

            groupBox4.Enabled = false;
        }

        private void butenviar5_Click(object sender, EventArgs e)
        {
            if (radiopregunta5op2.Checked == true)
            {
                nota += 20;
                groupBox5.BackColor = Color.LimeGreen;
                labelestado5.Text = "Correcto 20/20";
            }
            else
            {
                groupBox5.BackColor = Color.Red;
                labelestado5.Text = "Incorrecto 0/20";
            }

            groupBox5.Enabled = false;

            

            
              
            
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
           
        }

        private void butcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butvernota_Click(object sender, EventArgs e)
        {

            if (groupBox1.Enabled == false & groupBox2.Enabled == false & groupBox3.Enabled == false & groupBox4.Enabled == false & groupBox5.Enabled == false)

            {
                label3.Text = Convert.ToString(nota) + "/100";


                if (nota >= 70)
                {
                    groupBox6.BackColor = Color.LimeGreen;
                    label5.Text = "Aprobaste";

                }
                else
                {
                    groupBox6.BackColor = Color.Red;
                    label5.Text = "Reprobaste";
                }
            }
            
        }
    }
}
