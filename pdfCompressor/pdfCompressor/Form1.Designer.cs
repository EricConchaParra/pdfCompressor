namespace pdfCompressor
{
    partial class CompresorDTE
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompresorDTE));
            this.txtRutaDestino = new System.Windows.Forms.TextBox();
            this.cbComprimir = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cBxTipo_Doc = new System.Windows.Forms.ComboBox();
            this.dgvDTE = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbInfoCarga = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnAbrePDF = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtRutaPDF = new System.Windows.Forms.TextBox();
            this.btnExaminaPDF = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbRelacionador = new System.Windows.Forms.RadioButton();
            this.rbRelacionado = new System.Windows.Forms.RadioButton();
            this.cBxTipo_Doc_Cargado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCarga = new System.Windows.Forms.Button();
            this.cBxTipo_Doc_Rel = new System.Windows.Forms.ComboBox();
            this.txtNumero_Rel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbAbrirCarpeta = new System.Windows.Forms.CheckBox();
            this.cbEnviarEmail = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnVaciarTabla = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTE)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRutaDestino
            // 
            this.txtRutaDestino.Location = new System.Drawing.Point(108, 59);
            this.txtRutaDestino.Name = "txtRutaDestino";
            this.txtRutaDestino.Size = new System.Drawing.Size(319, 20);
            this.txtRutaDestino.TabIndex = 1;
            // 
            // cbComprimir
            // 
            this.cbComprimir.AutoSize = true;
            this.cbComprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComprimir.Location = new System.Drawing.Point(9, 22);
            this.cbComprimir.Name = "cbComprimir";
            this.cbComprimir.Size = new System.Drawing.Size(142, 17);
            this.cbComprimir.TabIndex = 6;
            this.cbComprimir.Text = "Comprimir en formato Zip";
            this.cbComprimir.UseVisualStyleBackColor = true;
            this.cbComprimir.CheckedChanged += new System.EventHandler(this.cbComprimir_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.cBxTipo_Doc);
            this.groupBox2.Location = new System.Drawing.Point(10, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Documentos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(74, 119);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Añadir";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Documento";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(74, 77);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(150, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // cBxTipo_Doc
            // 
            this.cBxTipo_Doc.FormattingEnabled = true;
            this.cBxTipo_Doc.Location = new System.Drawing.Point(74, 34);
            this.cBxTipo_Doc.Name = "cBxTipo_Doc";
            this.cBxTipo_Doc.Size = new System.Drawing.Size(150, 21);
            this.cBxTipo_Doc.TabIndex = 0;
            this.cBxTipo_Doc.SelectedIndexChanged += new System.EventHandler(this.cBxTipo_Doc_SelectedIndexChanged);
            // 
            // dgvDTE
            // 
            this.dgvDTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTE.Location = new System.Drawing.Point(7, 20);
            this.dgvDTE.Name = "dgvDTE";
            this.dgvDTE.Size = new System.Drawing.Size(514, 406);
            this.dgvDTE.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbInfoCarga);
            this.groupBox3.Controls.Add(this.dgvDTE);
            this.groupBox3.Location = new System.Drawing.Point(520, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 464);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Documentos";
            // 
            // lbInfoCarga
            // 
            this.lbInfoCarga.AutoSize = true;
            this.lbInfoCarga.Location = new System.Drawing.Point(6, 441);
            this.lbInfoCarga.Name = "lbInfoCarga";
            this.lbInfoCarga.Size = new System.Drawing.Size(0, 13);
            this.lbInfoCarga.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnExaminar);
            this.groupBox4.Controls.Add(this.btnAbrePDF);
            this.groupBox4.Controls.Add(this.txtRutaDestino);
            this.groupBox4.Controls.Add(this.btnAbrir);
            this.groupBox4.Controls.Add(this.txtRutaPDF);
            this.groupBox4.Controls.Add(this.btnExaminaPDF);
            this.groupBox4.Location = new System.Drawing.Point(10, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(502, 98);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rutas de archivos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Carpeta de Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ruta Origen PDFs";
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackgroundImage = global::pdfCompressor.Properties.Resources.folder_icon1;
            this.btnExaminar.Location = new System.Drawing.Point(427, 58);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(30, 23);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnAbrePDF
            // 
            this.btnAbrePDF.BackgroundImage = global::pdfCompressor.Properties.Resources.folder_icon1;
            this.btnAbrePDF.Location = new System.Drawing.Point(427, 23);
            this.btnAbrePDF.Name = "btnAbrePDF";
            this.btnAbrePDF.Size = new System.Drawing.Size(30, 23);
            this.btnAbrePDF.TabIndex = 2;
            this.btnAbrePDF.UseVisualStyleBackColor = true;
            this.btnAbrePDF.Click += new System.EventHandler(this.btnAbrePDF_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackgroundImage = global::pdfCompressor.Properties.Resources.lupa_icon1;
            this.btnAbrir.Location = new System.Drawing.Point(456, 58);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(28, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtRutaPDF
            // 
            this.txtRutaPDF.Location = new System.Drawing.Point(108, 24);
            this.txtRutaPDF.Name = "txtRutaPDF";
            this.txtRutaPDF.Size = new System.Drawing.Size(319, 20);
            this.txtRutaPDF.TabIndex = 1;
            // 
            // btnExaminaPDF
            // 
            this.btnExaminaPDF.BackgroundImage = global::pdfCompressor.Properties.Resources.lupa_icon1;
            this.btnExaminaPDF.Location = new System.Drawing.Point(456, 23);
            this.btnExaminaPDF.Name = "btnExaminaPDF";
            this.btnExaminaPDF.Size = new System.Drawing.Size(28, 23);
            this.btnExaminaPDF.TabIndex = 0;
            this.btnExaminaPDF.UseVisualStyleBackColor = true;
            this.btnExaminaPDF.Click += new System.EventHandler(this.btnExaminaPDF_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.rbRelacionador);
            this.groupBox5.Controls.Add(this.rbRelacionado);
            this.groupBox5.Controls.Add(this.cBxTipo_Doc_Cargado);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnCarga);
            this.groupBox5.Controls.Add(this.cBxTipo_Doc_Rel);
            this.groupBox5.Controls.Add(this.txtNumero_Rel);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(265, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 198);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Carga Masiva Documentos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo Documento Origen";
            // 
            // rbRelacionador
            // 
            this.rbRelacionador.AutoSize = true;
            this.rbRelacionador.Checked = true;
            this.rbRelacionador.Location = new System.Drawing.Point(9, 136);
            this.rbRelacionador.Name = "rbRelacionador";
            this.rbRelacionador.Size = new System.Drawing.Size(88, 17);
            this.rbRelacionador.TabIndex = 8;
            this.rbRelacionador.TabStop = true;
            this.rbRelacionador.Text = "Relacionador";
            this.rbRelacionador.UseVisualStyleBackColor = true;
            // 
            // rbRelacionado
            // 
            this.rbRelacionado.AutoSize = true;
            this.rbRelacionado.Location = new System.Drawing.Point(111, 136);
            this.rbRelacionado.Name = "rbRelacionado";
            this.rbRelacionado.Size = new System.Drawing.Size(85, 17);
            this.rbRelacionado.TabIndex = 7;
            this.rbRelacionado.Text = "Relacionado";
            this.rbRelacionado.UseVisualStyleBackColor = true;
            // 
            // cBxTipo_Doc_Cargado
            // 
            this.cBxTipo_Doc_Cargado.FormattingEnabled = true;
            this.cBxTipo_Doc_Cargado.Location = new System.Drawing.Point(86, 86);
            this.cBxTipo_Doc_Cargado.Name = "cBxTipo_Doc_Cargado";
            this.cBxTipo_Doc_Cargado.Size = new System.Drawing.Size(148, 21);
            this.cBxTipo_Doc_Cargado.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Docs a Cargar";
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(83, 165);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(110, 23);
            this.btnCarga.TabIndex = 4;
            this.btnCarga.Text = "Cargar Documentos";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // cBxTipo_Doc_Rel
            // 
            this.cBxTipo_Doc_Rel.FormattingEnabled = true;
            this.cBxTipo_Doc_Rel.Location = new System.Drawing.Point(86, 25);
            this.cBxTipo_Doc_Rel.Name = "cBxTipo_Doc_Rel";
            this.cBxTipo_Doc_Rel.Size = new System.Drawing.Size(148, 21);
            this.cBxTipo_Doc_Rel.TabIndex = 3;
            // 
            // txtNumero_Rel
            // 
            this.txtNumero_Rel.Location = new System.Drawing.Point(86, 56);
            this.txtNumero_Rel.Name = "txtNumero_Rel";
            this.txtNumero_Rel.Size = new System.Drawing.Size(148, 20);
            this.txtNumero_Rel.TabIndex = 2;
            this.txtNumero_Rel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumero_Rel_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Documento";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbAbrirCarpeta);
            this.groupBox6.Controls.Add(this.cbEnviarEmail);
            this.groupBox6.Controls.Add(this.cbComprimir);
            this.groupBox6.Location = new System.Drawing.Point(10, 362);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(500, 105);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Opciones adicionales";
            // 
            // cbAbrirCarpeta
            // 
            this.cbAbrirCarpeta.AutoSize = true;
            this.cbAbrirCarpeta.Checked = true;
            this.cbAbrirCarpeta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAbrirCarpeta.Location = new System.Drawing.Point(9, 50);
            this.cbAbrirCarpeta.Name = "cbAbrirCarpeta";
            this.cbAbrirCarpeta.Size = new System.Drawing.Size(182, 17);
            this.cbAbrirCarpeta.TabIndex = 8;
            this.cbAbrirCarpeta.Text = "Abrir carpeta de salida al terminar";
            this.cbAbrirCarpeta.UseVisualStyleBackColor = true;
            // 
            // cbEnviarEmail
            // 
            this.cbEnviarEmail.AutoSize = true;
            this.cbEnviarEmail.Location = new System.Drawing.Point(9, 78);
            this.cbEnviarEmail.Name = "cbEnviarEmail";
            this.cbEnviarEmail.Size = new System.Drawing.Size(181, 17);
            this.cbEnviarEmail.TabIndex = 7;
            this.cbEnviarEmail.Text = "Abrir Gestor de Correo al terminar";
            this.cbEnviarEmail.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnVaciarTabla);
            this.groupBox7.Controls.Add(this.btnSalir);
            this.groupBox7.Controls.Add(this.btnSetup);
            this.groupBox7.Controls.Add(this.btnProcesar);
            this.groupBox7.Location = new System.Drawing.Point(10, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(502, 47);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            // 
            // btnVaciarTabla
            // 
            this.btnVaciarTabla.BackgroundImage = global::pdfCompressor.Properties.Resources.deleteData_icono;
            this.btnVaciarTabla.Location = new System.Drawing.Point(80, 12);
            this.btnVaciarTabla.Name = "btnVaciarTabla";
            this.btnVaciarTabla.Size = new System.Drawing.Size(32, 32);
            this.btnVaciarTabla.TabIndex = 7;
            this.btnVaciarTabla.UseVisualStyleBackColor = true;
            this.btnVaciarTabla.Click += new System.EventHandler(this.btnVaciarTabla_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.Location = new System.Drawing.Point(6, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetup.BackgroundImage")));
            this.btnSetup.Location = new System.Drawing.Point(117, 12);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(32, 32);
            this.btnSetup.TabIndex = 5;
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProcesar.BackgroundImage")));
            this.btnProcesar.Location = new System.Drawing.Point(43, 12);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(32, 32);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // CompresorDTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 475);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompresorDTE";
            this.Text = "Copiar DTE";
            this.Load += new System.EventHandler(this.CompresorDTE_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTE)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtRutaDestino;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cBxTipo_Doc;
        private System.Windows.Forms.DataGridView dgvDTE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAbrePDF;
        private System.Windows.Forms.TextBox txtRutaPDF;
        private System.Windows.Forms.Button btnExaminaPDF;
        private System.Windows.Forms.CheckBox cbComprimir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cBxTipo_Doc_Rel;
        private System.Windows.Forms.TextBox txtNumero_Rel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbEnviarEmail;
        private System.Windows.Forms.CheckBox cbAbrirCarpeta;
        private System.Windows.Forms.ComboBox cBxTipo_Doc_Cargado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbRelacionador;
        private System.Windows.Forms.RadioButton rbRelacionado;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVaciarTabla;
        private System.Windows.Forms.Label lbInfoCarga;
    }
}

