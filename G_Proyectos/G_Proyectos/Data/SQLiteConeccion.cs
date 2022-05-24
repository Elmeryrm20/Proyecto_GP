using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using G_Proyectos.SQLite;
using System.Threading.Tasks;

namespace G_Proyectos.Data
{
    public class SQLiteConeccion
    {
        SQLiteAsyncConnection db;
        public SQLiteConeccion(string dbpath)
        {
            db = new SQLiteAsyncConnection(dbpath);
            db.CreateTableAsync<Usuario>().Wait();
            db.CreateTableAsync<Paciente>().Wait();
            db.CreateTableAsync<Monitoreo>().Wait();
            db.CreateTableAsync<Medico>().Wait();

        }
        public Task<int> InsertarUsuario(Usuario user)
        {
                return db.InsertAsync(user);
        }
        public Task<int> InsertarPaciente(Paciente pacient)
        {
            if (pacient.Id==0)
            {
                return db.InsertAsync(pacient);
            }
            else
            {
                return null;
            }
           
        }
    }
}
