namespace pdfCompressor
{
    partial class config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(config));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnAbrePDF = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btnExaminaPDF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.cbMostrarPass = new System.Windows.Forms.CheckBox();
            this.txtSetAdminPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen PDFs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carpeta de Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Servidor MySQL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Base de Datos del ERP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExaminar);
            this.groupBox1.Controls.Add(this.txtSalida);
            this.groupBox1.Controls.Add(this.btnAbrePDF);
            this.groupBox1.Controls.Add(this.btnAbrir);
            this.groupBox1.Controls.Add(this.txtOrigen);
            this.groupBox1.Controls.Add(this.btnExaminaPDF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(314, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivos PDF";
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackgroundImage = global::pdfCompressor.Properties.Resources.folder_icon1;
            this.btnExaminar.Location = new System.Drawing.Point(345, 55);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(30, 23);
            this.btnExaminar.TabIndex = 5;
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(97, 56);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(251, 20);
            this.txtSalida.TabIndex = 3;
            // 
            // btnAbrePDF
            // 
            this.btnAbrePDF.BackgroundImage = global::pdfCompressor.Properties.Resources.folder_icon1;
            this.btnAbrePDF.Location = new System.Drawing.Point(345, 27);
            this.btnAbrePDF.Name = "btnAbrePDF";
            this.btnAbrePDF.Size = new System.Drawing.Size(30, 23);
            this.btnAbrePDF.TabIndex = 6;
            this.btnAbrePDF.UseVisualStyleBackColor = true;
            this.btnAbrePDF.Click += new System.EventHandler(this.btnAbrePDF_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackgroundImage = global::pdfCompressor.Properties.Resources.lupa_icon1;
            this.btnAbrir.Location = new System.Drawing.Point(374, 55);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(28, 23);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(97, 29);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(251, 20);
            this.txtOrigen.TabIndex = 2;
            // 
            // btnExaminaPDF
            // 
            this.btnExaminaPDF.BackgroundImage = global::pdfCompressor.Properties.Resources.lupa_icon1;
            this.btnExaminaPDF.Location = new System.Drawing.Point(374, 27);
            this.btnExaminaPDF.Name = "btnExaminaPDF";
            this.btnExaminaPDF.Size = new System.Drawing.Size(28, 23);
            this.btnExaminaPDF.TabIndex = 4;
            this.btnExaminaPDF.UseVisualStyleBackColor = true;
            this.btnExaminaPDF.Click += new System.EventHandler(this.btnExaminaPDF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPuerto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDB);
            this.groupBox2.Controls.Add(this.txtPass);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(8, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 234);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Integración con Sigue ERP";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(131, 58);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(163, 20);
            this.txtPuerto.TabIndex = 11;
            this.txtPuerto.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Puerto";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(131, 157);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(163, 20);
            this.txtDB.TabIndex = 9;
            this.txtDB.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(131, 124);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(163, 20);
            this.txtPass.TabIndex = 8;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(131, 91);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(163, 20);
            this.txtUser.TabIndex = 7;
            this.txtUser.UseSystemPasswordChar = true;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(131, 25);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(163, 20);
            this.txtIP.TabIndex = 6;
            this.txtIP.UseSystemPasswordChar = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAdminPass);
            this.groupBox3.Controls.Add(this.btnPass);
            this.groupBox3.Controls.Add(this.btnGrabar);
            this.groupBox3.Controls.Add(this.btnVolver);
            this.groupBox3.Location = new System.Drawing.Point(9, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(715, 40);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Location = new System.Drawing.Point(112, 13);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(187, 20);
            this.txtAdminPass.TabIndex = 3;
            this.txtAdminPass.UseSystemPasswordChar = true;
            this.txtAdminPass.Visible = false;
            this.txtAdminPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAdminPass_KeyUp_1);
            // 
            // btnPass
            // 
            this.btnPass.BackgroundImage = global::pdfCompressor.Properties.Resources.pass_icono;
            this.btnPass.Location = new System.Drawing.Point(74, 8);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(32, 32);
            this.btnPass.TabIndex = 2;
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGrabar.BackgroundImage")));
            this.btnGrabar.Location = new System.Drawing.Point(38, 7);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(32, 32);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click_1);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::pdfCompressor.Properties.Resources.salir_icono1;
            this.btnVolver.Location = new System.Drawing.Point(2, 7);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(32, 32);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.cbMostrarPass);
            this.gbAdmin.Controls.Add(this.txtSetAdminPass);
            this.gbAdmin.Controls.Add(this.label7);
            this.gbAdmin.Location = new System.Drawing.Point(314, 153);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(410, 135);
            this.gbAdmin.TabIndex = 9;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Administración";
            this.gbAdmin.Visible = false;
            // 
            // cbMostrarPass
            // 
            this.cbMostrarPass.AutoSize = true;
            this.cbMostrarPass.Location = new System.Drawing.Point(6, 62);
            this.cbMostrarPass.Name = "cbMostrarPass";
            this.cbMostrarPass.Size = new System.Drawing.Size(163, 17);
            this.cbMostrarPass.TabIndex = 2;
            this.cbMostrarPass.Text = "Mostrar datos Enmascarados";
            this.cbMostrarPass.UseVisualStyleBackColor = true;
            this.cbMostrarPass.CheckedChanged += new System.EventHandler(this.cbMostrarPass_CheckedChanged);
            // 
            // txtSetAdminPass
            // 
            this.txtSetAdminPass.Location = new System.Drawing.Point(115, 30);
            this.txtSetAdminPass.Name = "txtSetAdminPass";
            this.txtSetAdminPass.Size = new System.Drawing.Size(243, 20);
            this.txtSetAdminPass.TabIndex = 1;
            this.txtSetAdminPass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Clave Administrador";
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 300);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "config";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.config_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.TextBox txtSetAdminPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbMostrarPass;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnAbrePDF;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnExaminaPDF;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label8;
    }
}