using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace G_Proyectos.SQLite
{
    public class Monitoreobase
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public int Precion { get; set; }

        [MaxLength(50)]
        public DateTime FecRegistro { get; set; }

        [MaxLength(100)]
        public string NotaMonitoreo { get; set; }


    }

}