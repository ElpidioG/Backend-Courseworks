
namespace RegistroEstudiantes
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
            this.labelname = new System.Windows.Forms.Label();
            this.labellast = new System.Windows.Forms.Label();
            this.labelcurso = new System.Windows.Forms.Label();
            this.labelfecha = new System.Windows.Forms.Label();
            this.labelnota1 = new System.Windows.Forms.Label();
            this.labelnota2 = new System.Windows.Forms.Label();
            this.labelnota3 = new System.Windows.Forms.Label();
            this.labelpromedio = new System.Windows.Forms.Label();
            this.labelnota4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textLastn = new System.Windows.Forms.TextBox();
            this.textCurso = new System.Windows.Forms.TextBox();
            this.textNota1 = new System.Windows.Forms.TextBox();
            this.textNota4 = new System.Windows.Forms.TextBox();
            this.textNota2 = new System.Windows.Forms.TextBox();
            this.textNota3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLenguaEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataMatematica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCienciasSociales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCienciasNaturales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butagregar = new System.Windows.Forms.Button();
            this.comboAsignatura = new System.Windows.Forms.ComboBox();
            this.comboDía = new System.Windows.Forms.ComboBox();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.comboAño = new System.Windows.Forms.ComboBox();
            this.butcalc = new System.Windows.Forms.Button();
            this.textpromedio = new System.Windows.Forms.TextBox();
            this.labeldia = new System.Windows.Forms.Label();
            this.labelmes = new System.Windows.Forms.Label();
            this.labelaño = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butborrar = new System.Windows.Forms.Button();
            this.butcerrar = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelname.Location = new System.Drawing.Point(288, 135);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(86, 25);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Nombre";
            // 
            // labellast
            // 
            this.labellast.AutoSize = true;
            this.labellast.BackColor = System.Drawing.Color.Transparent;
            this.labellast.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labellast.Location = new System.Drawing.Point(288, 175);
            this.labellast.Name = "labellast";
            this.labellast.Size = new System.Drawing.Size(86, 25);
            this.labellast.TabIndex = 1;
            this.labellast.Text = "Apellido";
            // 
            // labelcurso
            // 
            this.labelcurso.AutoSize = true;
            this.labelcurso.BackColor = System.Drawing.Color.Transparent;
            this.labelcurso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelcurso.Location = new System.Drawing.Point(288, 222);
            this.labelcurso.Name = "labelcurso";
            this.labelcurso.Size = new System.Drawing.Size(64, 25);
            this.labelcurso.TabIndex = 2;
            this.labelcurso.Text = "Curso";
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.BackColor = System.Drawing.Color.Transparent;
            this.labelfecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelfecha.Location = new System.Drawing.Point(288, 260);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(196, 25);
            this.labelfecha.TabIndex = 3;
            this.labelfecha.Text = "Fecha de Nacimiento";
            // 
            // labelnota1
            // 
            this.labelnota1.AutoSize = true;
            this.labelnota1.BackColor = System.Drawing.Color.Transparent;
            this.labelnota1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelnota1.Location = new System.Drawing.Point(680, 139);
            this.labelnota1.Name = "labelnota1";
            this.labelnota1.Size = new System.Drawing.Size(72, 25);
            this.labelnota1.TabIndex = 4;
            this.labelnota1.Text = "Nota 1";
            // 
            // labelnota2
            // 
            this.labelnota2.AutoSize = true;
            this.labelnota2.BackColor = System.Drawing.Color.Transparent;
            this.labelnota2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelnota2.Location = new System.Drawing.Point(680, 173);
            this.labelnota2.Name = "labelnota2";
            this.labelnota2.Size = new System.Drawing.Size(72, 25);
            this.labelnota2.TabIndex = 5;
            this.labelnota2.Text = "Nota 2";
            // 
            // labelnota3
            // 
            this.labelnota3.AutoSize = true;
            this.labelnota3.BackColor = System.Drawing.Color.Transparent;
            this.labelnota3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelnota3.Location = new System.Drawing.Point(680, 211);
            this.labelnota3.Name = "labelnota3";
            this.labelnota3.Size = new System.Drawing.Size(72, 25);
            this.labelnota3.TabIndex = 6;
            this.labelnota3.Text = "Nota 3";
            // 
            // labelpromedio
            // 
            this.labelpromedio.AutoSize = true;
            this.labelpromedio.BackColor = System.Drawing.Color.Transparent;
            this.labelpromedio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelpromedio.Location = new System.Drawing.Point(637, 282);
            this.labelpromedio.Name = "labelpromedio";
            this.labelpromedio.Size = new System.Drawing.Size(100, 25);
            this.labelpromedio.TabIndex = 7;
            this.labelpromedio.Text = "Promedio";
            // 
            // labelnota4
            // 
            this.labelnota4.AutoSize = true;
            this.labelnota4.BackColor = System.Drawing.Color.Transparent;
            this.labelnota4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelnota4.Location = new System.Drawing.Point(680, 248);
            this.labelnota4.Name = "labelnota4";
            this.labelnota4.Size = new System.Drawing.Size(72, 25);
            this.labelnota4.TabIndex = 8;
            this.labelnota4.Text = "Nota 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(680, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Asignatura";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(394, 136);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 23);
            this.textName.TabIndex = 10;
            // 
            // textLastn
            // 
            this.textLastn.Location = new System.Drawing.Point(394, 177);
            this.textLastn.Name = "textLastn";
            this.textLastn.Size = new System.Drawing.Size(100, 23);
            this.textLastn.TabIndex = 11;
            // 
            // textCurso
            // 
            this.textCurso.Location = new System.Drawing.Point(394, 223);
            this.textCurso.Name = "textCurso";
            this.textCurso.Size = new System.Drawing.Size(100, 23);
            this.textCurso.TabIndex = 12;
            // 
            // textNota1
            // 
            this.textNota1.Enabled = false;
            this.textNota1.Location = new System.Drawing.Point(758, 141);
            this.textNota1.Name = "textNota1";
            this.textNota1.Size = new System.Drawing.Size(40, 23);
            this.textNota1.TabIndex = 14;
            // 
            // textNota4
            // 
            this.textNota4.Enabled = false;
            this.textNota4.Location = new System.Drawing.Point(758, 248);
            this.textNota4.Name = "textNota4";
            this.textNota4.Size = new System.Drawing.Size(40, 23);
            this.textNota4.TabIndex = 17;
            // 
            // textNota2
            // 
            this.textNota2.Enabled = false;
            this.textNota2.Location = new System.Drawing.Point(758, 173);
            this.textNota2.Name = "textNota2";
            this.textNota2.Size = new System.Drawing.Size(40, 23);
            this.textNota2.TabIndex = 15;
            // 
            // textNota3
            // 
            this.textNota3.Enabled = false;
            this.textNota3.Location = new System.Drawing.Point(758, 211);
            this.textNota3.Name = "textNota3";
            this.textNota3.Size = new System.Drawing.Size(40, 23);
            this.textNota3.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(385, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(338, 40);
            this.label11.TabIndex = 19;
            this.label11.Text = "Registro de Estudiantes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataID,
            this.DataNombre,
            this.DataApellido,
            this.DataCurso,
            this.DataFechaNac,
            this.DataEdad,
            this.DataLenguaEsp,
            this.DataMatematica,
            this.DataCienciasSociales,
            this.DataCienciasNaturales,
            this.DataPromedio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 425);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataID
            // 
            this.dataID.HeaderText = "ID";
            this.dataID.Name = "dataID";
            // 
            // DataNombre
            // 
            this.DataNombre.HeaderText = "Nombre";
            this.DataNombre.Name = "DataNombre";
            // 
            // DataApellido
            // 
            this.DataApellido.HeaderText = "Apellido";
            this.DataApellido.Name = "DataApellido";
            // 
            // DataCurso
            // 
            this.DataCurso.HeaderText = "Curso";
            this.DataCurso.Name = "DataCurso";
            // 
            // DataFechaNac
            // 
            this.DataFechaNac.HeaderText = "Fecha Nacimiento";
            this.DataFechaNac.Name = "DataFechaNac";
            // 
            // DataEdad
            // 
            this.DataEdad.HeaderText = "Edad";
            this.DataEdad.Name = "DataEdad";
            // 
            // DataLenguaEsp
            // 
            this.DataLenguaEsp.HeaderText = "Promedio Lengua Española";
            this.DataLenguaEsp.Name = "DataLenguaEsp";
            // 
            // DataMatematica
            // 
            this.DataMatematica.HeaderText = "Promedio Matematicas";
            this.DataMatematica.Name = "DataMatematica";
            // 
            // DataCienciasSociales
            // 
            this.DataCienciasSociales.HeaderText = "Promedio Ciencias Sociales";
            this.DataCienciasSociales.Name = "DataCienciasSociales";
            // 
            // DataCienciasNaturales
            // 
            this.DataCienciasNaturales.HeaderText = "Promedio Ciencias Naturales";
            this.DataCienciasNaturales.Name = "DataCienciasNaturales";
            // 
            // DataPromedio
            // 
            this.DataPromedio.HeaderText = "Promedio General";
            this.DataPromedio.Name = "DataPromedio";
            // 
            // butagregar
            // 
            this.butagregar.Enabled = false;
            this.butagregar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.butagregar.Location = new System.Drawing.Point(232, 365);
            this.butagregar.Name = "butagregar";
            this.butagregar.Size = new System.Drawing.Size(90, 40);
            this.butagregar.TabIndex = 24;
            this.butagregar.Text = "Agregar";
            this.butagregar.UseVisualStyleBackColor = true;
            this.butagregar.Click += new System.EventHandler(this.butagregar_Click);
            // 
            // comboAsignatura
            // 
            this.comboAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAsignatura.FormattingEnabled = true;
            this.comboAsignatura.Items.AddRange(new object[] {
            "Lengua Española",
            "Matematicas",
            "Ciencias Sociales",
            "Ciencias Naturales",
            " "});
            this.comboAsignatura.Location = new System.Drawing.Point(680, 113);
            this.comboAsignatura.Name = "comboAsignatura";
            this.comboAsignatura.Size = new System.Drawing.Size(121, 23);
            this.comboAsignatura.TabIndex = 13;
            this.comboAsignatura.SelectedIndexChanged += new System.EventHandler(this.comboAsignatura_SelectedIndexChanged);
            // 
            // comboDía
            // 
            this.comboDía.AccessibleName = "";
            this.comboDía.DisplayMember = "Fff";
            this.comboDía.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDía.FormattingEnabled = true;
            this.comboDía.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            " "});
            this.comboDía.Location = new System.Drawing.Point(264, 300);
            this.comboDía.Name = "comboDía";
            this.comboDía.Size = new System.Drawing.Size(51, 23);
            this.comboDía.TabIndex = 30;
            this.comboDía.SelectedIndexChanged += new System.EventHandler(this.comboDía_SelectedIndexChanged);
            this.comboDía.Click += new System.EventHandler(this.comboDía_Click);
            this.comboDía.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboDía_MouseClick);
            // 
            // comboMes
            // 
            this.comboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            " "});
            this.comboMes.Location = new System.Drawing.Point(360, 299);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(51, 23);
            this.comboMes.TabIndex = 31;
            // 
            // comboAño
            // 
            this.comboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAño.FormattingEnabled = true;
            this.comboAño.Items.AddRange(new object[] {
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            " "});
            this.comboAño.Location = new System.Drawing.Point(462, 299);
            this.comboAño.Name = "comboAño";
            this.comboAño.Size = new System.Drawing.Size(51, 23);
            this.comboAño.TabIndex = 32;
            // 
            // butcalc
            // 
            this.butcalc.Enabled = false;
            this.butcalc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.butcalc.Location = new System.Drawing.Point(637, 321);
            this.butcalc.Name = "butcalc";
            this.butcalc.Size = new System.Drawing.Size(90, 40);
            this.butcalc.TabIndex = 18;
            this.butcalc.Text = "Calcular";
            this.butcalc.UseVisualStyleBackColor = true;
            this.butcalc.Click += new System.EventHandler(this.butcalc_Click);
            // 
            // textpromedio
            // 
            this.textpromedio.Location = new System.Drawing.Point(758, 287);
            this.textpromedio.Name = "textpromedio";
            this.textpromedio.ReadOnly = true;
            this.textpromedio.Size = new System.Drawing.Size(40, 23);
            this.textpromedio.TabIndex = 34;
            // 
            // labeldia
            // 
            this.labeldia.AutoSize = true;
            this.labeldia.BackColor = System.Drawing.Color.Transparent;
            this.labeldia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeldia.Location = new System.Drawing.Point(232, 304);
            this.labeldia.Name = "labeldia";
            this.labeldia.Size = new System.Drawing.Size(32, 20);
            this.labeldia.TabIndex = 35;
            this.labeldia.Text = "Día";
            this.labeldia.Click += new System.EventHandler(this.labeldia_Click);
            this.labeldia.MouseLeave += new System.EventHandler(this.labeldia_MouseLeave);
            this.labeldia.MouseHover += new System.EventHandler(this.labeldia_MouseHover);
            // 
            // labelmes
            // 
            this.labelmes.AutoSize = true;
            this.labelmes.BackColor = System.Drawing.Color.Transparent;
            this.labelmes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelmes.Location = new System.Drawing.Point(322, 303);
            this.labelmes.Name = "labelmes";
            this.labelmes.Size = new System.Drawing.Size(38, 20);
            this.labelmes.TabIndex = 36;
            this.labelmes.Text = "Mes";
            // 
            // labelaño
            // 
            this.labelaño.AutoSize = true;
            this.labelaño.BackColor = System.Drawing.Color.Transparent;
            this.labelaño.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelaño.Location = new System.Drawing.Point(423, 303);
            this.labelaño.Name = "labelaño";
            this.labelaño.Size = new System.Drawing.Size(38, 20);
            this.labelaño.TabIndex = 37;
            this.labelaño.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // butborrar
            // 
            this.butborrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.butborrar.Location = new System.Drawing.Point(342, 365);
            this.butborrar.Name = "butborrar";
            this.butborrar.Size = new System.Drawing.Size(90, 40);
            this.butborrar.TabIndex = 39;
            this.butborrar.Text = "Borrar";
            this.butborrar.UseVisualStyleBackColor = true;
            this.butborrar.Click += new System.EventHandler(this.butborrar_Click);
            // 
            // butcerrar
            // 
            this.butcerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.butcerrar.Location = new System.Drawing.Point(956, 365);
            this.butcerrar.Name = "butcerrar";
            this.butcerrar.Size = new System.Drawing.Size(90, 40);
            this.butcerrar.TabIndex = 40;
            this.butcerrar.Text = "Cerrar";
            this.butcerrar.UseVisualStyleBackColor = true;
            this.butcerrar.Click += new System.EventHandler(this.butcerrar_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.Transparent;
            this.labelid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelid.Location = new System.Drawing.Point(290, 95);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(32, 25);
            this.labelid.TabIndex = 41;
            this.labelid.Text = "ID";
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(394, 95);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 23);
            this.textID.TabIndex = 42;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1116, 659);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.butcerrar);
            this.Controls.Add(this.butborrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelaño);
            this.Controls.Add(this.labelmes);
            this.Controls.Add(this.labeldia);
            this.Controls.Add(this.textpromedio);
            this.Controls.Add(this.butcalc);
            this.Controls.Add(this.comboAño);
            this.Controls.Add(this.comboMes);
            this.Controls.Add(this.comboDía);
            this.Controls.Add(this.butagregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textNota3);
            this.Controls.Add(this.textNota2);
            this.Controls.Add(this.textNota4);
            this.Controls.Add(this.textNota1);
            this.Controls.Add(this.comboAsignatura);
            this.Controls.Add(this.textCurso);
            this.Controls.Add(this.textLastn);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelnota4);
            this.Controls.Add(this.labelpromedio);
            this.Controls.Add(this.labelnota3);
            this.Controls.Add(this.labelnota2);
            this.Controls.Add(this.labelnota1);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.labelcurso);
            this.Controls.Add(this.labellast);
            this.Controls.Add(this.labelname);
            this.Name = "Form1";
            this.Text = " ";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labellast;
        private System.Windows.Forms.Label labelcurso;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.Label labelnota1;
        private System.Windows.Forms.Label labelnota2;
        private System.Windows.Forms.Label labelnota3;
        private System.Windows.Forms.Label labelpromedio;
        private System.Windows.Forms.Label labelnota4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLastn;
        private System.Windows.Forms.TextBox textCurso;
        private System.Windows.Forms.TextBox textNota1;
        private System.Windows.Forms.TextBox textNota4;
        private System.Windows.Forms.TextBox textNota2;
        private System.Windows.Forms.TextBox textNota3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butagregar;
        private System.Windows.Forms.ComboBox comboAsignatura;
        private System.Windows.Forms.ComboBox comboDía;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.ComboBox comboAño;
        private System.Windows.Forms.Button butcalc;
        private System.Windows.Forms.TextBox textpromedio;
        private System.Windows.Forms.Label labeldia;
        private System.Windows.Forms.Label labelmes;
        private System.Windows.Forms.Label labelaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butborrar;
        private System.Windows.Forms.Button butcerrar;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLenguaEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataMatematica;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCienciasSociales;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCienciasNaturales;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPromedio;
    }
}

