using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace G_Proyectos.SQLite
{
    internal class Monitoreo
    {
        [PrimaryKey]
        public int Id { get; set; }
        public int Precion { get; set; }
        public DateTime fec_registro { get; set; }

        [MaxLength(100)]
        public string nota { get; set; }

    }
}
