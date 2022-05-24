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
        public IEnumerable<Usuario> BuscarUsuario(string correo, string contra)
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
        public IEnumerable<Monitoreobase> Hipoglucemia(string numero)
        {
            var result = db.QueryAsync<Monitoreobase>("Select * from Monitoreobase Where Precion<=65 and FecRegistro<=MONTH(numero)", numero);
            return result.Result;
        }
        public Task<int> ActualiarUsuario(Usuario date)
        {
            return db.UpdateAsync(date);
        }
        public IEnumerable<Monitoreobase> NormoGlucemia1_Normal(string Fecha)
        {
            var result = db.QueryAsync<Monitoreobase>("Select * from Monitoreobase Where Precion<=132 and Precion>=66 and FecRegistro=?", Fecha);
            return result.Result;
        }
        public IEnumerable<Monitoreobase> NormoGlucemia1_Bueno(string Fecha)
        {
            var result = db.QueryAsync<Monitoreobase>("Select * from Monitoreobase Where Precion<=197 and Precion>=133 and FecRegistro=?", Fecha);
            return result.Result;
        }
        public IEnumerable<Monitoreobase> NormoGlucemia1_Malo(string Fecha)
        {
            var result = db.QueryAsync<Monitoreobase>("Select * from Monitoreobase Where Precion<=397 and Precion>=198 and FecRegistro=?", Fecha);
            return result.Result;
        }
        public IEnumerable<Monitoreobase> HiperGlucemia(string Fecha)
        {
            var result = db.QueryAsync<Monitoreobase>("Select * from Monitoreobase Where Precion>=398 and FecRegistro=?", Fecha);
            return result.Result;
        }
    }
}
