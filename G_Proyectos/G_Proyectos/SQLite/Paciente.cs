using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace G_Proyectos.SQLite
{
    internal class Paciente
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FecNacimiento { get; set; }

        [MaxLength(9)]
        public string TelefonoP { get; set; }
        public string TipoPersona { get; set; }

    }
}
