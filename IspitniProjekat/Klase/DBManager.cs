using System;
using System.Collections.Generic;
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
    }
}
