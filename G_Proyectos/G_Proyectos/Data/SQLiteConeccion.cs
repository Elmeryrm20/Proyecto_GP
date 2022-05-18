using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using G_Proyectos.SQLite;

namespace G_Proyectos.Data
{
    public class SQLiteConeccion
    {
        SQLiteAsyncConnection db;
        public SQLiteConeccion(string dbpath)
        {
            db = new SQLiteAsyncConnection(dbpath);
            db.CreateTableAsync<Usuario>().Wait();
        }
    }
}
