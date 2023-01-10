
namespace pictureboxili
{
    partial class Form2
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
            this.picturepechu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picturelogout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturepechu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogout)).BeginInit();
            this.SuspendLayout();
            // 
            // picturepechu
            // 
            this.picturepechu.BackColor = System.Drawing.Color.Transparent;
            this.picturepechu.Image = global::pictureboxili.Properties.Resources.feo_z;
            this.picturepechu.Location = new System.Drawing.Point(175, 96);
            this.picturepechu.Name = "picturepechu";
            this.picturepechu.Size = new System.Drawing.Size(452, 316);
            this.picturepechu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturepechu.TabIndex = 7;
            this.picturepechu.TabStop = false;
            this.picturepechu.Click += new System.EventHandler(this.picturepechu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(312, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 51);
            this.label2.TabIndex = 10;
            this.label2.Text = "El Pechu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::pictureboxili.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(756, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picturelogout
            // 
            this.picturelogout.BackColor = System.Drawing.Color.Transparent;
            this.picturelogout.Image = global::pictureboxili.Properties.Resources.depositphotos_66251761_stock_photo_logout_circular_icon_on_white;
            this.picturelogout.Location = new System.Drawing.Point(701, 380);
            this.picturelogout.Name = "picturelogout";
            this.picturelogout.Size = new System.Drawing.Size(128, 70);
            this.picturelogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturelogout.TabIndex = 12;
            this.picturelogout.TabStop = false;
            this.picturelogout.Click += new System.EventHandler(this.picturelogout_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pictureboxili.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picturelogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picturepechu);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picturepechu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picturepechu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picturelogout;
    }
}