
namespace timer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.labeltime = new System.Windows.Forms.Label();
            this.butinicio = new System.Windows.Forms.Button();
            this.butstop = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelintervalo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tiempo
            // 
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.Location = new System.Drawing.Point(230, 54);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(93, 20);
            this.labeltime.TabIndex = 0;
            this.labeltime.Text = "Contador: ";
            this.labeltime.Click += new System.EventHandler(this.labeltime_Click);
            // 
            // butinicio
            // 
            this.butinicio.Location = new System.Drawing.Point(481, 44);
            this.butinicio.Name = "butinicio";
            this.butinicio.Size = new System.Drawing.Size(75, 23);
            this.butinicio.TabIndex = 1;
            this.butinicio.Text = "inicio";
            this.butinicio.UseVisualStyleBackColor = true;
            this.butinicio.Click += new System.EventHandler(this.butinicio_Click);
            // 
            // butstop
            // 
            this.butstop.Location = new System.Drawing.Point(481, 92);
            this.butstop.Name = "butstop";
            this.butstop.Size = new System.Drawing.Size(75, 23);
            this.butstop.TabIndex = 2;
            this.butstop.Text = "detener";
            this.butstop.UseVisualStyleBackColor = true;
            this.butstop.Click += new System.EventHandler(this.butstop_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(234, 132);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(221, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelintervalo
            // 
            this.labelintervalo.AutoSize = true;
            this.labelintervalo.Location = new System.Drawing.Point(250, 197);
            this.labelintervalo.Name = "labelintervalo";
            this.labelintervalo.Size = new System.Drawing.Size(35, 13);
            this.labelintervalo.TabIndex = 4;
            this.labelintervalo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelintervalo);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.butstop);
            this.Controls.Add(this.butinicio);
            this.Controls.Add(this.labeltime);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Button butinicio;
        private System.Windows.Forms.Button butstop;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelintervalo;
    }
}

