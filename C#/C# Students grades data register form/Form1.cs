using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiantes
{
    public partial class Form1 : Form
    {
        private int List = 0;

 
        
        int edad;
        int id = 1;
        
        double promedioL;
        double promedioM;
        double promedioN;
        double promedioS;
        double promedio;



        public Form1()
        {
            InitializeComponent();




            textID.Text = Convert.ToString(id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List = e.RowIndex;
            if (List != -1)
            {
                label1.Text = (string)dataGridView1.Rows[List].Cells[1].Value;
            }
        }

        private void butagregar_Click(object sender, EventArgs e)
        {
           

            // Agregar valores a los campos  
            
            
            if (comboDía.Text != "Día" && comboMes.Text != "Mes" && comboAño.Text != "Año")
            {
                DateTime fecha = new DateTime(Convert.ToInt32(comboAño.SelectedItem), Convert.ToInt32(comboMes.SelectedItem), Convert.ToInt32(comboDía.SelectedItem));
                int indice = dataGridView1.Rows.Add();
                edad = DateTime.Today.AddTicks(-fecha.Ticks).Year - 1;

                dataGridView1.Rows[indice].Cells[0].Value = textID.Text;
                dataGridView1.Rows[indice].Cells[1].Value = textName.Text;
                dataGridView1.Rows[indice].Cells[2].Value = textLastn.Text;
                dataGridView1.Rows[indice].Cells[3].Value = textCurso.Text;
                dataGridView1.Rows[indice].Cells[4].Value = Convert.ToString(comboDía.SelectedItem + "/" + comboMes.SelectedItem + "/" + comboAño.SelectedItem);
                dataGridView1.Rows[indice].Cells[5].Value = Convert.ToString(edad);
                dataGridView1.Rows[indice].Cells[6].Value = promedioL;
                dataGridView1.Rows[indice].Cells[7].Value = promedioM;
                dataGridView1.Rows[indice].Cells[8].Value = promedioS;
                dataGridView1.Rows[indice].Cells[9].Value = promedioN;
                dataGridView1.Rows[indice].Cells[10].Value = promedio;
                edad = 0;
                textName.Text = "";
                textLastn.Text = "";
                textCurso.Text = "";
                textNota1.Text = "";
                textNota2.Text = "";
                textNota3.Text = "";
                textNota4.Text = "";
                textpromedio.Text = "";
                comboAsignatura.SelectedItem=" ";
                comboDía.SelectedItem = " ";
                comboMes.SelectedItem = " ";
                comboAño.SelectedItem = " ";

                promedioL = 0;
                promedio = 0;
                promedioM = 0;
                promedioS = 0;
                promedioN = 0;
                id = id + 1;
                textID.Text = Convert.ToString(id);

            }






          


        }

        private void comboAno_SelectedIndexChanged(object sender, EventArgs e)
        {

                
        }

        private void butcalc_Click(object sender, EventArgs e)
        {
            if (comboAsignatura.SelectedItem == "Lengua Española")
            {
                promedioL = (Convert.ToInt32(textNota1.Text) + Convert.ToInt32(textNota2.Text) + Convert.ToInt32(textNota3.Text) + Convert.ToInt32(textNota4.Text)) / 4;
                textpromedio.Text = Convert.ToString(promedioL);
            } else if (comboAsignatura.SelectedItem == "Matematicas")
            {
                promedioM = (Convert.ToInt32(textNota1.Text) + Convert.ToInt32(textNota2.Text) + Convert.ToInt32(textNota3.Text) + Convert.ToInt32(textNota4.Text)) / 4;
                textpromedio.Text = Convert.ToString(promedioM);
            }
            else if (comboAsignatura.SelectedItem == "Ciencias Sociales")
            {
                promedioS = (Convert.ToInt32(textNota1.Text) + Convert.ToInt32(textNota2.Text) + Convert.ToInt32(textNota3.Text) + Convert.ToInt32(textNota4.Text)) / 4;
                textpromedio.Text = Convert.ToString(promedioS);
            }
            else if (comboAsignatura.SelectedItem == "Ciencias Naturales")
            {
                promedioN = (Convert.ToInt32(textNota1.Text) + Convert.ToInt32(textNota2.Text) + Convert.ToInt32(textNota3.Text) + Convert.ToInt32(textNota4.Text)) / 4;
                textpromedio.Text = Convert.ToString(promedioN);
            }



            promedio = (promedioL + promedioM + promedioS + promedioN) / 4;
            
        }

        private void comboAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAsignatura.SelectedItem == "Lengua Española" || comboAsignatura.SelectedItem == "Matematicas" || comboAsignatura.SelectedItem == "Ciencias Sociales" || comboAsignatura.SelectedItem == "Ciencias Naturales")
            {


           
                textNota1.Enabled = true;
                textNota2.Enabled = true;
                textNota3.Enabled = true;
                textNota4.Enabled = true;

           

             textNota1.Text = "";
             textNota2.Text = "";
             textNota3.Text = "";
             textNota4.Text = "";
             textpromedio.Text = "";
                butcalc.Enabled = false;
            }
        }

        private void comboDía_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void comboDía_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void labeldia_Click(object sender, EventArgs e)
        {

        }

        private void labeldia_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void labeldia_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void comboDía_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
            


        }

        private void Form1_Activated(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            if (textNota1.Text != "" && textNota2.Text != "" && textNota3.Text != "" && textNota4.Text != "")
            {
                butcalc.Enabled = true;
            }
            else
            {
                butcalc.Enabled = false;
            }

        
            if (textName.Text != "" && textLastn.Text != "" && textCurso.Text != "")
            {
                if (comboDía.SelectedItem != "" && comboMes.SelectedItem != "" && comboAño.SelectedItem != "")
                {
                    if (promedioL != 0 && promedioM != 0 && promedioS != 0 && promedioN != 0)
                    {
                        butagregar.Enabled = true;
                    }
                }
            }
            else
            {
                butagregar.Enabled = false;
            }
       
        }

        private void butborrar_Click(object sender, EventArgs e)
        {
            if (List != -1)
            {
                dataGridView1.Rows.RemoveAt(List);
                id = id - 1;
                textID.Text = Convert.ToString(id);
            }
        }

        private void butcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
