
namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butaceptar = new System.Windows.Forms.Button();
            this.butcancelar = new System.Windows.Forms.Button();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.btwelcome = new System.Windows.Forms.Button();
            this.labelnombre = new System.Windows.Forms.Label();
            this.butcambio = new System.Windows.Forms.Button();
            this.buttraducir = new System.Windows.Forms.Button();
            this.butedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butaceptar
            // 
            this.butaceptar.BackColor = System.Drawing.Color.Red;
            this.butaceptar.FlatAppearance.BorderSize = 0;
            this.butaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butaceptar.Location = new System.Drawing.Point(285, 227);
            this.butaceptar.Name = "butaceptar";
            this.butaceptar.Size = new System.Drawing.Size(86, 35);
            this.butaceptar.TabIndex = 0;
            this.butaceptar.Text = "Aceptar";
            this.butaceptar.UseVisualStyleBackColor = false;
            this.butaceptar.Click += new System.EventHandler(this.butaceptar_Click);
            // 
            // butcancelar
            // 
            this.butcancelar.Location = new System.Drawing.Point(422, 227);
            this.butcancelar.Name = "butcancelar";
            this.butcancelar.Size = new System.Drawing.Size(92, 35);
            this.butcancelar.TabIndex = 1;
            this.butcancelar.Text = "Cancelar";
            this.butcancelar.UseVisualStyleBackColor = true;
            this.butcancelar.Visible = false;
            this.butcancelar.Click += new System.EventHandler(this.butcancelar_Click);
            // 
            // textnombre
            // 
            this.textnombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textnombre.Font = new System.Drawing.Font("New Super Mario Font U", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textnombre.Location = new System.Drawing.Point(304, 180);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(191, 35);
            this.textnombre.TabIndex = 2;
            this.textnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textnombre.TextChanged += new System.EventHandler(this.textnombre_TextChanged);
            // 
            // btwelcome
            // 
            this.btwelcome.Enabled = false;
            this.btwelcome.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btwelcome.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btwelcome.Location = new System.Drawing.Point(309, 82);
            this.btwelcome.Name = "btwelcome";
            this.btwelcome.Size = new System.Drawing.Size(190, 49);
            this.btwelcome.TabIndex = 3;
            this.btwelcome.Text = "Bienvenidos";
            this.btwelcome.UseVisualStyleBackColor = true;
            this.btwelcome.Click += new System.EventHandler(this.btwelcome_Click_1);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.BackColor = System.Drawing.Color.Transparent;
            this.labelnombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelnombre.Location = new System.Drawing.Point(304, 152);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(86, 25);
            this.labelnombre.TabIndex = 4;
            this.labelnombre.Text = "Nombre";
            // 
            // butcambio
            // 
            this.butcambio.BackgroundImage = global::WinFormsApp1.Properties.Resources.tile1;
            this.butcambio.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.butcambio.Location = new System.Drawing.Point(422, 287);
            this.butcambio.Name = "butcambio";
            this.butcambio.Size = new System.Drawing.Size(85, 29);
            this.butcambio.TabIndex = 5;
            this.butcambio.Text = "Cambio";
            this.butcambio.UseVisualStyleBackColor = true;
            this.butcambio.Click += new System.EventHandler(this.butcambio_Click);
            // 
            // buttraducir
            // 
            this.buttraducir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttraducir.Location = new System.Drawing.Point(285, 287);
            this.buttraducir.Name = "buttraducir";
            this.buttraducir.Size = new System.Drawing.Size(83, 29);
            this.buttraducir.TabIndex = 6;
            this.buttraducir.Text = "Traducir";
            this.buttraducir.UseVisualStyleBackColor = true;
            this.buttraducir.Click += new System.EventHandler(this.button1_Click);
            // 
            // butedit
            // 
            this.butedit.Location = new System.Drawing.Point(522, 190);
            this.butedit.Name = "butedit";
            this.butedit.Size = new System.Drawing.Size(69, 24);
            this.butedit.TabIndex = 7;
            this.butedit.Text = "editar";
            this.butedit.UseVisualStyleBackColor = true;
            this.butedit.Click += new System.EventHandler(this.butedit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butedit);
            this.Controls.Add(this.buttraducir);
            this.Controls.Add(this.butcambio);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.btwelcome);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.butcancelar);
            this.Controls.Add(this.butaceptar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butaceptar;
        private System.Windows.Forms.Button butcancelar;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Button btwelcome;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Button butcambio;
        private System.Windows.Forms.Button buttraducir;
        private System.Windows.Forms.Button butedit;
    }
}

