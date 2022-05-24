using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace G_Proyectos.SQLite
{
    public class Usuario
    {
        [PrimaryKey]
        public string CorreoU { get; set; }

        [MaxLength(50)]
        public string NombreU { get; set; }

        [MaxLength(20)]
        public string Contraseña { get; set; }

        [MaxLength(20)]

        public string NombreReal { get; set; }

        [MaxLength(20)]
        public string Apellido { get; set; }

        [MaxLength(20)]
        public DateTime FecNacimiento { get; set; }

        [MaxLength(20)]
        public string TelefonoP { get; set; }

        [MaxLength(20)]
        public string TipoPersona { get; set; }
    }
}
