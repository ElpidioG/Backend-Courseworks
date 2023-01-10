
namespace comboxbox
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
            this.comboBnombre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBadd = new System.Windows.Forms.TextBox();
            this.butagregar = new System.Windows.Forms.Button();
            this.butcerrar = new System.Windows.Forms.Button();
            this.butprint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBnombre
            // 
            this.comboBnombre.FormattingEnabled = true;
            this.comboBnombre.Items.AddRange(new object[] {
            "mango",
            "chinola",
            "pera",
            "uva",
            "sandia",
            "manzana",
            "limon",
            "china"});
            this.comboBnombre.Location = new System.Drawing.Point(160, 143);
            this.comboBnombre.Name = "comboBnombre";
            this.comboBnombre.Size = new System.Drawing.Size(121, 23);
            this.comboBnombre.TabIndex = 0;
            this.comboBnombre.SelectedIndexChanged += new System.EventHandler(this.comboBnombre_SelectedIndexChanged);
            this.comboBnombre.Click += new System.EventHandler(this.comboBnombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textBadd
            // 
            this.textBadd.Location = new System.Drawing.Point(107, 257);
            this.textBadd.Name = "textBadd";
            this.textBadd.Size = new System.Drawing.Size(100, 23);
            this.textBadd.TabIndex = 3;
            this.textBadd.TextChanged += new System.EventHandler(this.textBadd_TextChanged);
            this.textBadd.MouseHover += new System.EventHandler(this.textBadd_MouseHover);
            // 
            // butagregar
            // 
            this.butagregar.Location = new System.Drawing.Point(242, 256);
            this.butagregar.Name = "butagregar";
            this.butagregar.Size = new System.Drawing.Size(75, 23);
            this.butagregar.TabIndex = 4;
            this.butagregar.Text = "Agregar";
            this.butagregar.UseVisualStyleBackColor = true;
            this.butagregar.Click += new System.EventHandler(this.butagregar_Click);
            // 
            // butcerrar
            // 
            this.butcerrar.Location = new System.Drawing.Point(350, 255);
            this.butcerrar.Name = "butcerrar";
            this.butcerrar.Size = new System.Drawing.Size(75, 23);
            this.butcerrar.TabIndex = 5;
            this.butcerrar.Text = "Cerrar";
            this.butcerrar.UseVisualStyleBackColor = true;
            this.butcerrar.Click += new System.EventHandler(this.butcerrar_Click);
            // 
            // butprint
            // 
            this.butprint.Location = new System.Drawing.Point(303, 142);
            this.butprint.Name = "butprint";
            this.butprint.Size = new System.Drawing.Size(75, 23);
            this.butprint.TabIndex = 6;
            this.butprint.Text = "Print";
            this.butprint.UseVisualStyleBackColor = true;
            this.butprint.Click += new System.EventHandler(this.butprint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(442, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(637, 143);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butprint);
            this.Controls.Add(this.butcerrar);
            this.Controls.Add(this.butagregar);
            this.Controls.Add(this.textBadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBadd;
        private System.Windows.Forms.Button butagregar;
        private System.Windows.Forms.Button butcerrar;
        private System.Windows.Forms.Button butprint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

