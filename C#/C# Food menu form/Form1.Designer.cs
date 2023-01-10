
namespace checkbox5a
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelprecio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radiosandwich = new System.Windows.Forms.RadioButton();
            this.radiohamburguesa = new System.Windows.Forms.RadioButton();
            this.radionuggets = new System.Windows.Forms.RadioButton();
            this.checkpapa = new System.Windows.Forms.CheckBox();
            this.checkrefresco = new System.Windows.Forms.CheckBox();
            this.checkpostre = new System.Windows.Forms.CheckBox();
            this.butaceptar = new System.Windows.Forms.Button();
            this.labeltotal = new System.Windows.Forms.Label();
            this.butcancel = new System.Windows.Forms.Button();
            this.butcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelprecio
            // 
            this.labelprecio.AutoSize = true;
            this.labelprecio.Location = new System.Drawing.Point(69, 61);
            this.labelprecio.Name = "labelprecio";
            this.labelprecio.Size = new System.Drawing.Size(40, 15);
            this.labelprecio.TabIndex = 0;
            this.labelprecio.Text = "Precio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // radiosandwich
            // 
            this.radiosandwich.AutoSize = true;
            this.radiosandwich.Location = new System.Drawing.Point(33, 13);
            this.radiosandwich.Name = "radiosandwich";
            this.radiosandwich.Size = new System.Drawing.Size(76, 19);
            this.radiosandwich.TabIndex = 2;
            this.radiosandwich.TabStop = true;
            this.radiosandwich.Text = "Sandwich";
            this.radiosandwich.UseVisualStyleBackColor = true;
            this.radiosandwich.CheckedChanged += new System.EventHandler(this.radiosandwich_CheckedChanged);
            // 
            // radiohamburguesa
            // 
            this.radiohamburguesa.AutoSize = true;
            this.radiohamburguesa.Location = new System.Drawing.Point(155, 13);
            this.radiohamburguesa.Name = "radiohamburguesa";
            this.radiohamburguesa.Size = new System.Drawing.Size(100, 19);
            this.radiohamburguesa.TabIndex = 3;
            this.radiohamburguesa.TabStop = true;
            this.radiohamburguesa.Text = "Hamburguesa";
            this.radiohamburguesa.UseVisualStyleBackColor = true;
            this.radiohamburguesa.CheckedChanged += new System.EventHandler(this.radiohamburguesa_CheckedChanged);
            // 
            // radionuggets
            // 
            this.radionuggets.AutoSize = true;
            this.radionuggets.Location = new System.Drawing.Point(288, 13);
            this.radionuggets.Name = "radionuggets";
            this.radionuggets.Size = new System.Drawing.Size(70, 19);
            this.radionuggets.TabIndex = 4;
            this.radionuggets.TabStop = true;
            this.radionuggets.Text = "Nuggets";
            this.radionuggets.UseVisualStyleBackColor = true;
            this.radionuggets.CheckedChanged += new System.EventHandler(this.radionuggets_CheckedChanged);
            // 
            // checkpapa
            // 
            this.checkpapa.AutoSize = true;
            this.checkpapa.Location = new System.Drawing.Point(125, 113);
            this.checkpapa.Name = "checkpapa";
            this.checkpapa.Size = new System.Drawing.Size(77, 19);
            this.checkpapa.TabIndex = 5;
            this.checkpapa.Text = "Con papa";
            this.checkpapa.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkpapa.UseVisualStyleBackColor = true;
            // 
            // checkrefresco
            // 
            this.checkrefresco.AutoSize = true;
            this.checkrefresco.Location = new System.Drawing.Point(125, 138);
            this.checkrefresco.Name = "checkrefresco";
            this.checkrefresco.Size = new System.Drawing.Size(93, 19);
            this.checkrefresco.TabIndex = 6;
            this.checkrefresco.Text = "Con refresco";
            this.checkrefresco.UseVisualStyleBackColor = true;
            // 
            // checkpostre
            // 
            this.checkpostre.AutoSize = true;
            this.checkpostre.Location = new System.Drawing.Point(125, 163);
            this.checkpostre.Name = "checkpostre";
            this.checkpostre.Size = new System.Drawing.Size(84, 19);
            this.checkpostre.TabIndex = 7;
            this.checkpostre.Text = "Con postre";
            this.checkpostre.UseVisualStyleBackColor = true;
            // 
            // butaceptar
            // 
            this.butaceptar.Location = new System.Drawing.Point(125, 225);
            this.butaceptar.Name = "butaceptar";
            this.butaceptar.Size = new System.Drawing.Size(75, 23);
            this.butaceptar.TabIndex = 8;
            this.butaceptar.Text = "Aceptar";
            this.butaceptar.UseVisualStyleBackColor = true;
            this.butaceptar.Click += new System.EventHandler(this.butaceptar_Click);
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labeltotal.Location = new System.Drawing.Point(33, 311);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(38, 15);
            this.labeltotal.TabIndex = 9;
            this.labeltotal.Text = "label1";
            this.labeltotal.Visible = false;
            // 
            // butcancel
            // 
            this.butcancel.Location = new System.Drawing.Point(229, 224);
            this.butcancel.Name = "butcancel";
            this.butcancel.Size = new System.Drawing.Size(75, 23);
            this.butcancel.TabIndex = 10;
            this.butcancel.Text = "Cancelar";
            this.butcancel.UseVisualStyleBackColor = true;
            this.butcancel.Click += new System.EventHandler(this.butcancel_Click);
            // 
            // butcerrar
            // 
            this.butcerrar.Location = new System.Drawing.Point(338, 224);
            this.butcerrar.Name = "butcerrar";
            this.butcerrar.Size = new System.Drawing.Size(75, 23);
            this.butcerrar.TabIndex = 11;
            this.butcerrar.Text = "Cerrar";
            this.butcerrar.UseVisualStyleBackColor = true;
            this.butcerrar.Click += new System.EventHandler(this.butcerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butcerrar);
            this.Controls.Add(this.butcancel);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.butaceptar);
            this.Controls.Add(this.checkpostre);
            this.Controls.Add(this.checkrefresco);
            this.Controls.Add(this.checkpapa);
            this.Controls.Add(this.radionuggets);
            this.Controls.Add(this.radiohamburguesa);
            this.Controls.Add(this.radiosandwich);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelprecio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelprecio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radiosandwich;
        private System.Windows.Forms.RadioButton radiohamburguesa;
        private System.Windows.Forms.RadioButton radionuggets;
        private System.Windows.Forms.CheckBox checkpapa;
        private System.Windows.Forms.CheckBox checkrefresco;
        private System.Windows.Forms.CheckBox checkpostre;
        private System.Windows.Forms.Button butaceptar;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Button butcancel;
        private System.Windows.Forms.Button butcerrar;
    }
}

