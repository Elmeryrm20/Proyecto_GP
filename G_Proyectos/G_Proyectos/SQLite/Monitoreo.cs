using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using G_Proyectos.Data;
using SQLite;
namespace G_Proyectos.SQLite
{
    public class Monitoreo
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public int Precion { get; set; }
        public DateTime fec_registro { get; set; }

        [MaxLength(100)]
        public string nota { get; set; }

    }
}
