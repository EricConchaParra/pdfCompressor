using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace pdfCompressor
{

    public static class DBConnect
    {
        public static MySqlConnection connection;
        public static string server = leeXml.lee("ip_server");
        public static string puerto = leeXml.lee("puerto");
        public static string database = leeXml.lee("database");
        public static string uid = leeXml.lee("user");
        public static string password = leeXml.lee("pass");

                
        public static void AbreConexion()
        {
            string connectionString;

            connectionString = "SERVER=" + server + ";" + "PORT=" + puerto + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        
        //open connection to database
        public static bool OpenConnection()
        {
            try
            {
                AbreConexion();
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        //Select statement
        public static DataTable SelectRelacionador(string tipo_doc, string numero, int docRel)
        {
            //Que documento está procesando
            // 0 -> Todos
            // 1 -> GE
            // 2 -> Fact Elec
            // 3 -> NC
            // 4 -> ND

            string[] query = new string[5];


            // Todos
            query[0] = String.Format("SELECT M.DOCRELDOC as DOC, M.DOCRELNUM as NUM, C.RAZON as CLIENTE from MOVREL as M, CLIENTES as C where (M.DOCUMENT = '{0}' and M.NUMERO = {1}) and M.DOCRELRUT = C.RUT;", tipo_doc, numero);

            // Guia Electronica
            query[1] = String.Format("SELECT M.DOCRELDOC as DOC, M.DOCRELNUM as NUM, C.RAZON as CLIENTE from MOVREL as M, CLIENTES as C where (M.DOCUMENT = '{0}' and M.NUMERO = {1} and M.DOCRELDOC = '{2}') and M.DOCRELRUT = C.RUT;", tipo_doc, numero, "GE");

            // Factura Electrónica
            query[2] = String.Format("SELECT M.DOCRELDOC as DOC, M.DOCRELNUM as NUM, C.RAZON as CLIENTE from MOVREL as M, CLIENTES as C where (M.DOCUMENT = '{0}' and M.NUMERO = {1} and M.DOCRELDOC = '{2}') and M.DOCRELRUT = C.RUT;", tipo_doc, numero, "37");

            // Nota de Credito
            query[3] = String.Format("SELECT M.DOCRELDOC as DOC, M.DOCRELNUM as NUM, C.RAZON as CLIENTE from MOVREL as M, CLIENTES as C where (M.DOCUMENT = '{0}' and M.NUMERO = {1} and M.DOCRELDOC = '{2}') and M.DOCRELRUT = C.RUT;", tipo_doc, numero, "N3");

            // Nota de Débito
            query[4] = String.Format("SELECT M.DOCRELDOC as DOC, M.DOCRELNUM as NUM, C.RAZON as CLIENTE from MOVREL as M, CLIENTES as C where (M.DOCUMENT = '{0}' and M.NUMERO = {1} and M.DOCRELDOC = '{2}') and M.DOCRELRUT = C.RUT;", tipo_doc, numero, "N7");

            
            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query[docRel], connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                var dt = new DataTable();
                dt.Load(dataReader);
                            
                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return dt;
            }
            else
            {
                var dt = new DataTable();
                return dt;
            }

        }

        public static DataTable SelectRelacionado(string tipo_doc, string numero, int docRel)
        {
            //Que documento está procesando
            // 0 -> Todos
            // 1 -> GE
            // 2 -> Fact Elec
            // 3 -> NC
            // 4 -> ND
            string[] query = new string[5];


            // Todos
            query[0] = String.Format("SELECT M.DOCUMENT as DOC, M.NUMERO as NUM, C.RAZON as CLIENTE from MOVREL as M, CLIENTES as C where (M.DOCRELDOC = '{0}' and M.DOCRELNUM= {1}) and M.RUT = C.RUT;", tipo_doc, numero);

            // Guia Electronica
            query[1] = String.Format("SELECT M.DOCUMENT as DOC, M.NUMERO as NUM, C.RAZON as CLIENTE from MOVREL as M, CLIENTES as C where (M.DOCRELDOC = '{0}' and M.DOCRELNUM= {1} and M.DOCUMENT = '{2}') and M.RUT = C.RUT;", tipo_doc, numero, "GE");

            // Factura Electrónica
            query[2] = String.Format("SELECT M.DOCUMENT as DOC, M.NUMERO as NUM, C.RAZON as CLIENTE from MOVREL as M, CLIENTES as C where (M.DOCRELDOC = '{0}' and M.DOCRELNUM = {1} and M.DOCUMENT = '{2}') and M.RUT = C.RUT;", tipo_doc, numero, "37");

            // Nota de Credito
            query[3] = String.Format("SELECT M.DOCUMENT as DOC, M.NUMERO as NUM, C.RAZON as CLIENTE from MOVREL as M, CLIENTES as C where (M.DOCRELDOC = '{0}' and M.DOCRELNUM = {1} and M.DOCUMENT = '{2}') and M.RUT = C.RUT;", tipo_doc, numero, "N3");

            // Nota de Débito
            query[4] = String.Format("SELECT M.DOCUMENT as DOC, M.NUMERO as NUM, C.RAZON as CLIENTE from MOVREL as M, CLIENTES as C where (M.DOCRELDOC = '{0}' and M.DOCRELNUM = {1} and M.DOCUMENT = '{2}') and M.RUT = C.RUT;", tipo_doc, numero, "N7");
                        
            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query[docRel], connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                var dt = new DataTable();
                dt.Load(dataReader);

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return dt;
            }
            else
            {
                var dt = new DataTable();
                return dt;
            }

        }

        public static String SelectCliente(string tipo_doc, int numero)
        {
            string Razon = "";
            string query = String.Format("SELECT CLIENTES.RAZON as CLIENTE from CLIENTES, MOVMAE where (MOVMAE.DOCUMENT = '{0}' and MOVMAE.NUMERO = {1}) and  MOVMAE.RUT = CLIENTES.RUT;", tipo_doc, numero);
            //MessageBox.Show(query);
            
            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                var dt = new DataTable();
                dt.Load(dataReader);

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //Guarda resultado en un String
                try { 
                Razon = dt.Rows[0]["CLIENTE"].ToString();
                }
                catch
                {
                    Razon = null;
                }

                //return list to be displayed
                return Razon;
            }
            else
            {
                Razon = null;
                return Razon;
            }

        }


    }
}
