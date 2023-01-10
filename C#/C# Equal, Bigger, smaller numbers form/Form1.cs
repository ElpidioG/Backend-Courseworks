using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butverificar_Click(object sender, EventArgs e)
        {

            
              if (comboBoxA.Text == "" || comboBoxB.Text == "" || comboBoxC.Text == "")
            {
                MessageBox.Show("Los tres deben tener valor");

            }

            else if ((comboBoxA.Text == comboBoxB.Text || comboBoxA.Text == comboBoxC.Text || comboBoxB.Text == comboBoxC.Text) && !(comboBoxA.Text == comboBoxB.Text && comboBoxA.Text == comboBoxC.Text && comboBoxB.Text == comboBoxC.Text))
            {
                MessageBox.Show("Dos son iguales");

            }

            else if (comboBoxA.Text == comboBoxB.Text && comboBoxA.Text == comboBoxC.Text && comboBoxB.Text == comboBoxC.Text)
            {
                MessageBox.Show("Los tres son iguales");
            }

            
            if (!(comboBoxA.Text == "" || comboBoxB.Text == "" || comboBoxC.Text == ""))
            {
                if (!(comboBoxA.Text == comboBoxB.Text || comboBoxA.Text == comboBoxC.Text || comboBoxB.Text == comboBoxC.Text))
                {
                    // A es mayor
                    if (Convert.ToInt32(comboBoxA.Text) > Convert.ToInt32(comboBoxB.Text) && Convert.ToInt32(comboBoxA.Text) > Convert.ToInt32(comboBoxC.Text))
                    {
                        label2.Visible = true;
                        
                        label2.Text = "A es el mayor";
                        if (Convert.ToInt32(comboBoxA.Text) > Convert.ToInt32(comboBoxB.Text) && Convert.ToInt32(comboBoxB.Text) > Convert.ToInt32(comboBoxC.Text))
                        {

                            label3.Visible = true;
                            label3.Text = "B es el del medio";
                            label4.Visible = true;
                            label4.Text = "C es el menor";


                        }
                        else if (Convert.ToInt32(comboBoxA.Text) > Convert.ToInt32(comboBoxC.Text) && Convert.ToInt32(comboBoxC.Text) > Convert.ToInt32(comboBoxB.Text))
                        {
                            label4.Visible = true;
                            label4.Text = "C es el del medio";
                            label3.Visible = true;
                            label3.Text = "B es el menor";
                        }


                    }

                    //B es mayor

                    if (Convert.ToInt32(comboBoxB.Text) > Convert.ToInt32(comboBoxA.Text) && Convert.ToInt32(comboBoxB.Text) > Convert.ToInt32(comboBoxC.Text))
                    {
                        label3.Visible = true;
                        label3.Text = "B es el mayor";
                        if (Convert.ToInt32(comboBoxB.Text) > Convert.ToInt32(comboBoxA.Text) && Convert.ToInt32(comboBoxA.Text) > Convert.ToInt32(comboBoxC.Text))
                        {

                            label2.Visible = true;
                            label2.Text = "A es el del medio";
                            label4.Visible = true;
                            label4.Text = "C es el menor";


                        }
                        else if (Convert.ToInt32(comboBoxB.Text) > Convert.ToInt32(comboBoxC.Text) && Convert.ToInt32(comboBoxC.Text) > Convert.ToInt32(comboBoxA.Text))
                        {
                            label4.Visible = true;
                            label4.Text = "C es el del medio";
                            label2.Visible = true;
                            label2.Text = "A es el menor";
                        }


                    }

                    //C es mayor

                    if (Convert.ToInt32(comboBoxC.Text) > Convert.ToInt32(comboBoxA.Text) && Convert.ToInt32(comboBoxC.Text) > Convert.ToInt32(comboBoxB.Text))
                    {
                        label4.Visible = true;
                        label4.Text = "C es el mayor";
                        if (Convert.ToInt32(comboBoxC.Text) > Convert.ToInt32(comboBoxA.Text) && Convert.ToInt32(comboBoxA.Text) > Convert.ToInt32(comboBoxB.Text))
                        {

                            label2.Visible = true;
                            label2.Text = "A es el del medio";
                            label3.Visible = true;
                            label3.Text = "B es el menor";


                        }
                        else if (Convert.ToInt32(comboBoxC.Text) > Convert.ToInt32(comboBoxB.Text) && Convert.ToInt32(comboBoxB.Text) > Convert.ToInt32(comboBoxA.Text))
                        {
                            label3.Visible = true;
                            label3.Text = "B es el del medio";
                            label2.Visible = true;
                            label2.Text = "A es el menor";
                        }


                    }


                }
            }

        }

        private void butlimpiar_Click(object sender, EventArgs e)
        {
            comboBoxA.Text = "";
            comboBoxB.Text = "";
            comboBoxC.Text = "";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void butcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
