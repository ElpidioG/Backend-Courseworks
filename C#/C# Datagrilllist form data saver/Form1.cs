using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagrillist5a
{
    public partial class Form1 : Form
    {
        private int List = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void butagregar_Click(object sender, EventArgs e)
        {
            // Agregar valores a los campos  
            int indice = dataGridlista.Rows.Add();
            dataGridlista.Rows[indice].Cells[0].Value = textId.Text;
            dataGridlista.Rows[indice].Cells[1].Value = textName.Text;
            dataGridlista.Rows[indice].Cells[2].Value = textPhone.Text;


            textId.Text = "";
            textName.Text = "";
            textPhone.Text = "";
            textId.Focus();
        }

        private void butcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butborrar_Click(object sender, EventArgs e)
        {
            if (List != -1)
            {
                dataGridlista.Rows.RemoveAt(List);
            }


        }

        private void dataGridlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List = e.RowIndex;
            if (List != -1)
            {
                label4.Text = (string)dataGridlista.Rows[List].Cells[1].Value;
            }
            
        }
    }
}
