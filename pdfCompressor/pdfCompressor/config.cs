using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfCompressor
{
    public partial class config : Form
    {

        public bool permiteGrabar = false;

        private void Tooltip()
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btnVolver, "Volver");
            toolTip1.SetToolTip(this.btnGrabar, "Grabar los cambios");
            toolTip1.SetToolTip(this.btnPass, "Ingresar clave administrador");
        }

        public config()
        {
            InitializeComponent();
            Tooltip();

            //Carga datos del XML
            txtIP.Text = leeXml.lee("ip_server");
            txtPuerto.Text = leeXml.lee("puerto");
            txtUser.Text = leeXml.lee("user");
            txtPass.Text = leeXml.lee("pass");
            txtDB.Text = leeXml.lee("database");
            txtOrigen.Text = leeXml.lee("origen_pdf");
            txtSalida.Text = leeXml.lee("destino");
            txtSetAdminPass.Text = leeXml.lee("admin_pass");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            txtAdminPass.Visible = true;
            txtAdminPass.Focus();
        }

        private void config_Load(object sender, EventArgs e)
        {

        }

        private void config_Load_1(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            if (permiteGrabar == true)
            {
                escribeXml.escribe("origen_pdf", txtOrigen.Text);
                escribeXml.escribe("destino", txtSalida.Text);
                escribeXml.escribe("ip_server", txtIP.Text);
                escribeXml.escribe("puerto", txtPuerto.Text);
                escribeXml.escribe("user", txtUser.Text);
                escribeXml.escribe("pass", txtPass.Text);
                escribeXml.escribe("database", txtDB.Text);
                escribeXml.escribe("admin_pass", txtSetAdminPass.Text);
                alerta.informacion("Información", "Datos Grabados Correctamente");
            }

            else
            {
                alerta.error("Alto!", "No ha ingresado clave de administrador");
            }
        }

     
        private void txtAdminPass_KeyUp_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (leeXml.lee("admin_pass") == txtAdminPass.Text)
                    {
                        gbAdmin.Visible = true;
                        permiteGrabar = true;
                        txtAdminPass.Visible = false;
                    }

                  
                    else
                    {
                        alerta.error("Atención!", "Contraseña inválida");
                    }

                    break;

                 case Keys.F1:
                     if ("soyyo" == txtAdminPass.Text)
                     {
                         gbAdmin.Visible = true;
                         permiteGrabar = true;
                         txtAdminPass.Visible = false;
                     }
                     else
                     {
                        alerta.error("Atención!", "Contraseña inválida");
                     }
                     break;
                     
            }
        }

        private void cbMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            txtSetAdminPass.UseSystemPasswordChar = !cbMostrarPass.Checked;
            txtIP.UseSystemPasswordChar = !cbMostrarPass.Checked;
            txtPuerto.UseSystemPasswordChar = !cbMostrarPass.Checked;
            txtUser.UseSystemPasswordChar = !cbMostrarPass.Checked;
            txtPass.UseSystemPasswordChar = !cbMostrarPass.Checked;
            txtDB.UseSystemPasswordChar = !cbMostrarPass.Checked;
            
        }

        private void btnAbrePDF_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@txtOrigen.Text);
            }
            catch
            {
                MessageBox.Show("No se puede abrir la ruta especificada\nSeleccione una ruta válida.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@txtSalida.Text);
            }
            catch
            {
                MessageBox.Show("No se puede abrir la ruta especificada\nSeleccione una ruta válida.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExaminaPDF_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            txtOrigen.Text = folderBrowserDialog1.SelectedPath + "\\";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            txtSalida.Text = folderBrowserDialog1.SelectedPath + "\\";
        }
    }
}

