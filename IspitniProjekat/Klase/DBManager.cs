using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Odbc;

namespace IspitniProjekat.Klase
{
    class DBManager
    {
        private OdbcConnection oConnection = null;
        public DBManager()
        {
            oConnection = new OdbcConnection(Podesavanja.ConnectionString);
        }

        public ListaAtributa GetTableAttributes()
        {
            return new ListaAtributa();
        } 

        ~DBManager()
        {
            if (oConnection.State != ConnectionState.Open) return;
            oConnection.Close();
            oConnection.Dispose();
        }
    }
}
