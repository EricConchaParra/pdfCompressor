using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Xml;
using System.Text;
using System.Net.Mail;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace pdfCompressor
{
    public partial class CompresorDTE : Form
    {

        public DataTable dt = new DataTable();
        public DataTable dtCliente = new DataTable();
        public string xmlOrigenPDF;
        public string xmlDestino;
        public string iTipo_doc;
        public string sNombre;
        public int iNumero;
        public string sRuta;
        public string sDestino;
        public string sCliente;

     
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
            toolTip1.SetToolTip(this.btnSalir, "Salir");
            toolTip1.SetToolTip(this.btnSetup, "Cambiar Configuración");
            toolTip1.SetToolTip(this.btnProcesar, "Iniciar Proceso");
            toolTip1.SetToolTip(this.btnVaciarTabla, "Vaciar Tabla de Documentos");
        }


        public void actualizaTabla(string cod_doc, string nombre_doc, string numero_doc, string cliente_doc, string rutaPDF)
        {
            if (cod_doc == "XX")
            {
                //No hace nada porque el doc relacionado no es electrónico
            }

            else
            {
                DataRow row = dt.NewRow();
                row["Cód."] = cod_doc;
                row["Documento" +
                    ""] = nombre_doc; // !!!
                row["Número"] = numero_doc;
                row["Cliente"] = cliente_doc;
                row["Ruta"] = rutaPDF + "dte-" + cod_doc + "-" + numero_doc + ".pdf";

                //Añade el registro a la tabla 
                dt.Rows.Add(row);

                dgvDTE.DataSource = dt; //añades la tabla al datagrid 
                dgvDTE.Update(); //actualizas 

                //Fija el ancho de las columnas
                DataGridViewColumn cod = dgvDTE.Columns[0];
                cod.Width = 50;

                DataGridViewColumn nombre = dgvDTE.Columns[1];
                nombre.Width = 100;

                DataGridViewColumn numero = dgvDTE.Columns[2];
                numero.Width = 80;

                DataGridViewColumn ruta = dgvDTE.Columns[3];
                ruta.Width = 220;
            }
        }

        public void actualizaTablaCliente(string cod_doc, string nombre_doc, string numero_doc, string rutaPDF)
        {
            if (cod_doc == "XX")
            {
                //No hace nada porque el doc relacionado no es electrónico
            }

            else
            {
                DataRow row = dt.NewRow();
                row["Cód."] = cod_doc;
                row["Documento"] = nombre_doc;
                row["Número"] = numero_doc;
                row["Cliente"] = sCliente;
                row["Ruta"] = rutaPDF + "dte-" + cod_doc + "-" + numero_doc + ".pdf";

                //Añade el registro a la tabla 
                dt.Rows.Add(row);

                dgvDTE.DataSource = dt; //añades la tabla al datagrid 
                dgvDTE.Update(); //actualizas 

                //Fija el ancho de las columnas
                DataGridViewColumn cod = dgvDTE.Columns[0];
                cod.Width = 50;

                DataGridViewColumn nombre = dgvDTE.Columns[1];
                nombre.Width = 100;

                DataGridViewColumn numero = dgvDTE.Columns[2];
                numero.Width = 110;

                DataGridViewColumn cliente = dgvDTE.Columns[3];
                numero.Width = 200;

                DataGridViewColumn ruta = dgvDTE.Columns[4];
                ruta.Width = 220;
            }
        }


        public CompresorDTE()
        {
            InitializeComponent();
            
            Tooltip();

            //Llena las columnas del DataGrid View
            //para que no se abra vacío
            dgvDTE.DataSource = dt;
            dgvDTE.Update();

            //Pregunta por XML
            string archivoXml = "config.xml";

            if (File.Exists(archivoXml) == true)
            {
                bool datoCorrecto;

                datoCorrecto = leeXml.verifica(leeXml.lee("origen_pdf"));

                if(datoCorrecto == false)
                {
                    alerta.error("Atención", "No se pudo cargar la ruta de origen, verifique configuración");
                    txtRutaPDF.Text = "";
                }

                else
                {
                    txtRutaPDF.Text = leeXml.lee("origen_pdf");
                }

                datoCorrecto = leeXml.verifica(leeXml.lee("destino"));

                if (datoCorrecto == false)
                {
                    alerta.error("Atención", "No se pudo cargar la ruta de destino, verifique configuración");
                    txtRutaPDF.Text = "";
                }

                else
                {
                    txtRutaDestino.Text = leeXml.lee("destino");
                }
               

            }

            else
            {
                alerta.error("Atención!", "Archivo de configuracion XML no existe, no se cargarán las rutas por defecto ni la conexion a la base de datos.");
            }

            //Lleno el ComboBox de Datos
            cBxTipo_Doc.Items.Insert(0, "Guía de Despacho");
            cBxTipo_Doc.Items.Insert(1, "Factura Electrónica");
            cBxTipo_Doc.Items.Insert(2, "Nota de Crédito");
            cBxTipo_Doc.Items.Insert(3, "Nota de Débito");
            cBxTipo_Doc.SelectedIndex = 1;

            //Lleno el ComboBox del Doc Relacionador con Datos
            cBxTipo_Doc_Rel.Items.Insert(0, "Guía de Despacho");
            cBxTipo_Doc_Rel.Items.Insert(1, "Factura Electrónica");
            cBxTipo_Doc_Rel.Items.Insert(2, "Nota de Crédito");
            cBxTipo_Doc_Rel.Items.Insert(3, "Nota de Débito");
            cBxTipo_Doc_Rel.SelectedIndex = 1;

            //Lleno el ComboBox de Doc a Relacionados a cargar
            cBxTipo_Doc_Cargado.Items.Insert(0, "Todos");
            cBxTipo_Doc_Cargado.Items.Insert(1, "Guía de Despacho");
            cBxTipo_Doc_Cargado.Items.Insert(2, "Factura Electrónica");
            cBxTipo_Doc_Cargado.Items.Insert(3, "Nota de Crédito");
            cBxTipo_Doc_Cargado.Items.Insert(4, "Nota de Débito");
            cBxTipo_Doc_Cargado.SelectedIndex = 0;

            
            //Añade las columnas necesarias al DataTable
            dt.Columns.Add("Cód.");
            dt.Columns.Add("Documento");
            dt.Columns.Add("Número");
            dt.Columns.Add("Cliente");
            dt.Columns.Add("Ruta");
            txtNumero.Focus();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void cBxTipo_Doc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Obtener Indice del CBx Selecionado
            int index_tipoDoc = cBxTipo_Doc.SelectedIndex;
            string doc_erp = "";
            switch (index_tipoDoc)
            {
                case 0:
                    iTipo_doc = "52";
                    doc_erp = "GE";
                    break;

                case 1:
                    iTipo_doc = "33";
                    doc_erp = "37";
                    break;

                case 2:
                    iTipo_doc = "61";
                    doc_erp = "N3";
                    break;

                case 3:
                    iTipo_doc = "56";
                    doc_erp = "N7";
                    break;
            }

            int numero = 0;
            Int32.TryParse(txtNumero.Text, out numero);
            string Cliente = DBConnect.SelectCliente(doc_erp, numero);

            if (Cliente == null){
                MessageBox.Show("No se encontró Documento.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                actualizaTabla(iTipo_doc, cBxTipo_Doc.SelectedItem.ToString(), txtNumero.Text, Cliente, txtRutaPDF.Text);
            }

            //Vacia el TextBox del numero
            txtNumero.Text = "";
            txtNumero.Focus();

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAgregar.PerformClick();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            txtRutaDestino.Text = folderBrowserDialog1.SelectedPath + "\\";
        }

        private void btnExaminaPDF_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            txtRutaPDF.Text = folderBrowserDialog1.SelectedPath + "\\";
        }

        private void btnAbrePDF_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@txtRutaPDF.Text);
            }
            catch
            {
                MessageBox.Show("No se puede abrir la ruta especificada\nSeleccione una ruta válida.", "Atención!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@txtRutaDestino.Text);
            }
            catch
            {
                MessageBox.Show("No se puede abrir la ruta especificada\nSeleccione una ruta válida.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Obtengo Primero la cantidad de filas del DataGridView
            int filas = dgvDTE.RowCount - 1;

            if (filas <= 0)
            {
                MessageBox.Show("Por favor agregue documentos a procesar.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                //Verifico que las carpetas existen y son validas
                if (Directory.Exists(txtRutaDestino.Text) && Directory.Exists(txtRutaPDF.Text) == true)

                {

                    //Verifico si comprimo los pdfs o no
                    bool comprime = cbComprimir.Checked;

                    if (comprime == false)
                    {
                        //Compienzo a procesar uno a uno

                        for (int i = 0; i < filas; i++)
                        {
                            string cpPath = dgvDTE[4, i].Value.ToString();

                            if (File.Exists(cpPath) == true)
                            {
                                File.Copy(cpPath, txtRutaDestino.Text + dgvDTE[2, i].Value.ToString() + " - " + dgvDTE[3, i].Value.ToString() + ".pdf", true);
                            }

                            else
                            {
                                MessageBox.Show("El archivo " + cpPath + " no se encontró y no se copiará.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        MessageBox.Show("Proceso Terminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (cbAbrirCarpeta.Checked == true)
                        {
                            System.Diagnostics.Process.Start(@txtRutaDestino.Text);
                        }

                    }

                    //Si debo comprimir hago lo siguiente
                    else
                    {
                        //Creo una carpeta temporal
                        System.IO.Directory.CreateDirectory("C:\\Sigue\\temp\\pdfs");

                        for (int i = 0; i < filas; i++)
                        {
                            string cpPath = dgvDTE[3, i].Value.ToString();

                            if (File.Exists(cpPath) == true)
                            {
                                File.Copy(cpPath, "C:\\Sigue\\temp\\pdfs\\" + Path.GetFileName(cpPath), true);
                            }

                            else
                            {
                                MessageBox.Show("El archivo " + cpPath + " no se encontró y no se copiará.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        try
                        {

                            ZipFile.CreateFromDirectory("C:\\Sigue\\temp\\pdfs", txtRutaDestino.Text + "PDFs" + DateTime.Now.ToString("yyyyMMdd-HHmm") + ".zip");
                            System.IO.Directory.Delete("C:\\Sigue\\temp\\pdfs", true);

                            if (cbEnviarEmail.Checked == true)
                            {
                                Process.Start("mailto:?subject=Envío de Documentos Tributarios Electrónicos");
                            }


                        }
                        catch
                        {
                            MessageBox.Show("No se pudo crear el archivo comprimido.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        finally
                        {
                            MessageBox.Show("Proceso Terminado!", "Información!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (cbAbrirCarpeta.Checked == true)
                            {
                                System.Diagnostics.Process.Start(@txtRutaDestino.Text);
                            }

                        }



                    }
                }
                else
                {
                    MessageBox.Show("Rutas de origen o destino inválidas\nPor favor verifique", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }





            }
        }

        private void cbComprimir_CheckedChanged(object sender, EventArgs e)
        {
            /*bool comprime = cbComprimir.Checked;
            if (comprime == true)
            {
                cbEnviarEmail.Enabled = true;
            }
            else
            {
                cbEnviarEmail.Checked = false;
                cbEnviarEmail.Enabled = false;
            }*/
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            try
            {

            
            //Creo un receptor para cargar los datos -Datatable-
            var dt = new DataTable();

            //Obtener Indice del CBx Selecionado
            int index_tipoDoc = cBxTipo_Doc_Rel.SelectedIndex;
            string Tipo_doc = "";
            switch (index_tipoDoc)
            {
                case 0:
                    Tipo_doc = "GE";
                    break;

                case 1:
                    Tipo_doc = "37";
                    break;

                case 2:
                    Tipo_doc = "N3";
                    break;

                case 3:
                    Tipo_doc = "N7";
                    break;
                    
            }
            
            //Que documento está procesando
            // 0 -> Todos
            // 1 -> GE
            // 2 -> Fact Elec
            // 3 -> NC
            // 4 -> ND

            int index_rel = cBxTipo_Doc_Cargado.SelectedIndex;

            //Recibe los datos de la consulta en una DataTable temporal
            //Pregunta donde si es relacionado o relacionador

            if (rbRelacionador.Checked)
            {
                dt = DBConnect.SelectRelacionador(Tipo_doc, txtNumero_Rel.Text, index_rel);
            }
            
            else if (rbRelacionado.Checked)
            {
                dt = DBConnect.SelectRelacionado(Tipo_doc, txtNumero_Rel.Text, index_rel);

            }

            //Procesa los datos del DataTable y Los inserta en la Grilla uno por uno

            string DOC;
            string NUM;
            string NAME="";
            
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No exiten documentos relacionados válidos para este folio.","Atencion!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DOC = dt.Rows[i]["DOC"].ToString();

                    switch (DOC)
                    {
                        case "GE":
                            DOC = "52";
                            NAME = "Guía de despacho";
                            break;

                        case "37":
                            DOC = "33";
                            NAME = "Factura Electrónica";
                            break;

                        case "N3":
                            DOC = "61";
                            NAME = "Nota de Crédito";
                            break;

                        case "N7":
                            DOC = "56";
                            NAME = "Nota de Débito";
                            break;

                        default:
                            DOC = "XX";
                            NAME = "Documento Inválido";
                            break;
                    }


                    NUM = dt.Rows[i]["NUM"].ToString();

                    actualizaTabla(DOC, NAME, NUM, dt.Rows[i]["CLIENTE"].ToString(), txtRutaPDF.Text);
                    
                }

                lbInfoCarga.Text = "Se cargaron " + dt.Rows.Count + " registros automáticamente.";
              }
            }
            catch(Exception ex)
            {
                alerta.error("Error", "Error: "+ ex);
            }

        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            config vConfig = new config();
            vConfig.ShowDialog(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVaciarTabla_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dgvDTE.DataSource = dt;
            dgvDTE.Update();
        
        }

        private void CompresorDTE_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_Rel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCarga.PerformClick();
            }
        }

        
    }
    }

