using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace G_Proyectos.SQLite
{
    public class Usuario
    {
        [PrimaryKey]
        public int CorreoU { get; set; }

        [MaxLength(50)]
        public string NombreU { get; set; }

        [MaxLength(20)]
        public string Contraseña { get; set; }
        
    }
}
