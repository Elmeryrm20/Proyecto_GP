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
            db.CreateTableAsync<Monitoreobase>().Wait();
            db.CreateTableAsync<Medico>().Wait();

        }
        public Task<int> InsertarUsuario(Usuario user)
        {
                return db.InsertAsync(user);
        }
        public Task<List<Usuario>> ListaUsuarios()
        {
            return db.Table<Usuario>().ToListAsync();
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
        public IEnumerable<Usuario> BuscarUsuario(string correo,string contra)
        {
            var result = db.QueryAsync<Usuario>("Select * from Usuario Where CorreoU=? and Contraseña=?", correo, contra);


            return result.Result;
        }
        public Task<List<Monitoreobase>> ListaMonitoreos()
        {
            return db.Table<Monitoreobase>().ToListAsync();
        }
        public Task<int> InsertarMonitoreo(Monitoreobase Mon)
        {
            return db.InsertAsync(Mon);
        }
    }
}
