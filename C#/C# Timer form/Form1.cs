using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace timer
{
   
    public partial class Form1 : Form
    {
        public int contador;
        public Form1()
        {
            InitializeComponent();
            contador = 0;
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            contador++;
            labeltime.Text = "Contador: " + contador.ToString();
        }

        private void butinicio_Click(object sender, EventArgs e)
        {
            tiempo.Enabled=true;
        }

        private void butstop_Click(object sender, EventArgs e)
        {
            tiempo.Enabled=false;
        }

        private void labeltime_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelintervalo.Text = trackBar1.Value.ToString();
            if (trackBar1.Value >0)
            {
                tiempo.Interval = trackBar1.Value;
            }
           
        }
    }
}
