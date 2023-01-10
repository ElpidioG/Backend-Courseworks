
namespace pictureboxili
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
            this.labelusuario = new System.Windows.Forms.Label();
            this.textusuario = new System.Windows.Forms.TextBox();
            this.textcontra = new System.Windows.Forms.TextBox();
            this.fotologin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelcontra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotologin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.BackColor = System.Drawing.Color.White;
            this.labelusuario.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusuario.ForeColor = System.Drawing.Color.Black;
            this.labelusuario.Location = new System.Drawing.Point(222, 88);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(47, 16);
            this.labelusuario.TabIndex = 1;
            this.labelusuario.Text = "Usuario";
            // 
            // textusuario
            // 
            this.textusuario.BackColor = System.Drawing.Color.White;
            this.textusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textusuario.Location = new System.Drawing.Point(243, 107);
            this.textusuario.Multiline = true;
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(157, 14);
            this.textusuario.TabIndex = 2;
            // 
            // textcontra
            // 
            this.textcontra.BackColor = System.Drawing.Color.White;
            this.textcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textcontra.Location = new System.Drawing.Point(244, 151);
            this.textcontra.Multiline = true;
            this.textcontra.Name = "textcontra";
            this.textcontra.Size = new System.Drawing.Size(157, 14);
            this.textcontra.TabIndex = 4;
            this.textcontra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fotologin
            // 
            this.fotologin.Image = global::pictureboxili.Properties.Resources.logi;
            this.fotologin.Location = new System.Drawing.Point(260, 183);
            this.fotologin.Name = "fotologin";
            this.fotologin.Size = new System.Drawing.Size(126, 44);
            this.fotologin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotologin.TabIndex = 5;
            this.fotologin.TabStop = false;
            this.fotologin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fotologin_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(239, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inicio de Sesión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::pictureboxili.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(600, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(279, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "                                 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(340, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "                                 ";
            // 
            // labelcontra
            // 
            this.labelcontra.AutoSize = true;
            this.labelcontra.BackColor = System.Drawing.Color.White;
            this.labelcontra.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcontra.Location = new System.Drawing.Point(222, 132);
            this.labelcontra.Name = "labelcontra";
            this.labelcontra.Size = new System.Drawing.Size(86, 16);
            this.labelcontra.TabIndex = 13;
            this.labelcontra.Text = "Contraseña    ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(224, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "                              ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label6.Location = new System.Drawing.Point(220, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "                              ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label7.Location = new System.Drawing.Point(238, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "                              ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pictureboxili.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 417);
            this.Controls.Add(this.fotologin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textusuario);
            this.Controls.Add(this.textcontra);
            this.Controls.Add(this.labelcontra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelusuario);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotologin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.TextBox textcontra;
        private System.Windows.Forms.PictureBox fotologin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelcontra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

