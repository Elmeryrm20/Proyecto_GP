using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace G_Proyectos.SQLite
{
    internal class Medico
    {
        [PrimaryKey]
        public int Id { get; set; }

        [MaxLength(9)]
        public string TelefonoM{ get; set; }

        public string CorreoM { get; set; }
    }
}
