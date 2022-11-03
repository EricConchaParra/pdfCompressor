using System;

namespace dbconnector
{ 

    public static class mysql
    {
	    public bool conectadb(string server, string database, string user, string pass)
	    {
            MySqlConnection conectar = new MySqlConnection("server=" + server +"; database=" + database+"; Uid=" + user + "; pwd=" + pass + ";");

            conectar.Open();
            exito = true;

            return exito;
        }
    }
}
