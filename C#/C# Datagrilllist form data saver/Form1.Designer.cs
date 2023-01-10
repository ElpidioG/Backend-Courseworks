
namespace datagrillist5a
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.butagregar = new System.Windows.Forms.Button();
            this.butborrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridlista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butcerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlista)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(57, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 15);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(55, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nombre";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(55, 119);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 15);
            this.labelTelefono.TabIndex = 2;
            this.labelTelefono.Text = "Telefono";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(136, 28);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 23);
            this.textId.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(136, 70);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 23);
            this.textName.TabIndex = 4;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(136, 116);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 23);
            this.textPhone.TabIndex = 5;
            // 
            // butagregar
            // 
            this.butagregar.BackColor = System.Drawing.Color.Aqua;
            this.butagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butagregar.Location = new System.Drawing.Point(283, 52);
            this.butagregar.Name = "butagregar";
            this.butagregar.Size = new System.Drawing.Size(75, 23);
            this.butagregar.TabIndex = 6;
            this.butagregar.Text = "Agregar";
            this.butagregar.UseVisualStyleBackColor = false;
            this.butagregar.Click += new System.EventHandler(this.butagregar_Click);
            // 
            // butborrar
            // 
            this.butborrar.BackColor = System.Drawing.Color.Aqua;
            this.butborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butborrar.Location = new System.Drawing.Point(283, 96);
            this.butborrar.Name = "butborrar";
            this.butborrar.Size = new System.Drawing.Size(75, 23);
            this.butborrar.TabIndex = 7;
            this.butborrar.Text = "Borrar";
            this.butborrar.UseVisualStyleBackColor = false;
            this.butborrar.Click += new System.EventHandler(this.butborrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // dataGridlista
            // 
            this.dataGridlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridlista.Location = new System.Drawing.Point(85, 215);
            this.dataGridlista.Name = "dataGridlista";
            this.dataGridlista.RowTemplate.Height = 25;
            this.dataGridlista.Size = new System.Drawing.Size(310, 150);
            this.dataGridlista.TabIndex = 9;
            this.dataGridlista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridlista_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.Name = "Column3";
            // 
            // butcerrar
            // 
            this.butcerrar.Location = new System.Drawing.Point(283, 395);
            this.butcerrar.Name = "butcerrar";
            this.butcerrar.Size = new System.Drawing.Size(75, 23);
            this.butcerrar.TabIndex = 10;
            this.butcerrar.Text = "Cerrar";
            this.butcerrar.UseVisualStyleBackColor = true;
            this.butcerrar.Click += new System.EventHandler(this.butcerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.butcerrar);
            this.Controls.Add(this.dataGridlista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butborrar);
            this.Controls.Add(this.butagregar);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button butagregar;
        private System.Windows.Forms.Button butborrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridlista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Button butcerrar;
    }
}

